using IS_v2.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = IS_v2.contexts.AppContext;

namespace IS_v2.forms
{
    public partial class CreateOrderForm : Form
    {
        private AppContext _context;
        private Form _parentForm;

        public CreateOrderForm(AppContext context, Form parentForm)
        {
            InitializeComponent();
            _context = context;
            _parentForm = parentForm;
            loadServices();
            loadComponents();
            this.FormClosed += CreateOrderForm_FormClosed;

        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            string[] paymentMethods = { "Наличные", "Карта" };

            comboBoxPaymentMethod.Items.AddRange(paymentMethods);
        }

        private void CreateOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadOrders();
                mainForm.loadComponents();
            }
        }

        private void loadServices()
        {
            comboBoxServices.DataSource = _context.services.ToList();
            comboBoxServices.DisplayMember = "Name";
            comboBoxServices.ValueMember = "ServiceId";
        }

        private void loadComponents()
        {
            comboBoxComponents.DataSource = _context.components.ToList();
            comboBoxComponents.DisplayMember = "Name";
            comboBoxComponents.ValueMember = "ComponentId";
        }

        private void buttonAddComponentToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxComponents.SelectedValue is int componentId)
            {
                var quantity = (int)numericUpDownComponentsQuantity.Value;

                var component = _context.components.Find(componentId);

                if (component != null && quantity > 0)
                {
                    dataGridViewOrderComponents.Rows.Add(component.ComponentId, component.Name, quantity, component.Price);

                    comboBoxComponents.SelectedIndex = -1;
                    numericUpDownComponentsQuantity.Value = 1;
                }
                else
                {
                    MessageBox.Show("Количество должно быть больше 0 и компонент должен существовать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Не удалось получить идентификатор компонента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddServiceToOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxServices.SelectedValue is int serviceId)
            {
                var service = _context.services.Find(serviceId);
                if (service != null)
                {
                    dataGridViewOrderServices.Rows.Add(service.ServiceId, service.Name, service.Price);
                    comboBoxServices.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите существующую услугу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Не удалось получить идентификатор услуги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAddNewOrder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDeviceName.Text) ||
                string.IsNullOrWhiteSpace(textBoxClientName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPhoneNum.Text) ||
                dataGridViewOrderComponents.Rows.Count == 0 ||
                dataGridViewOrderServices.Rows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля и добавьте хотя бы один компонент и одну услугу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var user = _context.users.FirstOrDefault(u => u.PhoneNumber == textBoxPhoneNum.Text);
                    if (user == null)
                    {
                        user = new User
                        {
                            Name = textBoxClientName.Text,
                            PhoneNumber = textBoxPhoneNum.Text
                        };
                        _context.users.Add(user);
                        _context.SaveChanges();
                    }

                    var order = new Order
                    {
                        CreatedAt = DateTime.UtcNow,
                        Status = "Создан",
                        Description = textBoxDescription.Text,
                        TotalPrice = CalculateTotalPrice(),
                        PaymentMethod = comboBoxPaymentMethod.SelectedItem.ToString(),
                        DeviceName = textBoxDeviceName.Text,
                        UserId = user.UserId
                    };

                    _context.orders.Add(order);
                    _context.SaveChanges();

                    List<int> selectedServiceIds = new List<int>();
                    foreach (DataGridViewRow serviceRow in dataGridViewOrderServices.Rows)
                    {
                        if (serviceRow.IsNewRow) continue;
                        var serviceId = Convert.ToInt32(serviceRow.Cells[0].Value);
                        selectedServiceIds.Add(serviceId);
                    }

                    foreach (DataGridViewRow row in dataGridViewOrderComponents.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var componentId = Convert.ToInt32(row.Cells[0].Value);
                        var quantity = Convert.ToInt32(row.Cells[2].Value);

                        var component = _context.components.Find(componentId);
                        if (component == null)
                        {
                            throw new Exception($"Компонент с ID {componentId} не найден.");
                        }

                        int serviceId = GetServiceIdForComponent(componentId, selectedServiceIds);
                        if (serviceId == 0)
                        {
                            throw new Exception("Не удалось найти соответствующий ServiceId для компонента.");
                        }

                        var orderComponent = new ServiceComponent
                        {
                            ComponentId = componentId,
                            Quantity = quantity,
                            ServiceId = serviceId
                        };
                        _context.service_components.Add(orderComponent);

                        component.Quantity -= quantity;
                    }

                    foreach (DataGridViewRow row in dataGridViewOrderServices.Rows)
                    {
                        if (row.IsNewRow) continue;
                        var serviceId = Convert.ToInt32(row.Cells[0].Value);

                        var service = _context.services.Find(serviceId);
                        if (service == null)
                        {
                            throw new Exception($"Услуга с ID {serviceId} не найдена.");
                        }

                        var orderService = new OrderService
                        {
                            OrderId = order.OrderId,
                            ServiceId = serviceId
                        };
                        _context.order_services.Add(orderService);
                    }

                    _context.SaveChanges();
                    transaction.Commit();

                    MessageBox.Show("Заказ успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка при создании заказа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int GetServiceIdForComponent(int componentId, List<int> serviceIds)
        {
            return serviceIds.FirstOrDefault();
        }



        private decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (DataGridViewRow row in dataGridViewOrderComponents.Rows)
            {
                if (row.IsNewRow) continue;
                var quantity = Convert.ToInt32(row.Cells[2].Value);
                var componentId = Convert.ToInt32(row.Cells[0].Value);
                var componentPrice = _context.components.Find(componentId).Price;
                totalPrice += quantity * componentPrice;
            }

            foreach (DataGridViewRow row in dataGridViewOrderServices.Rows)
            {
                if (row.IsNewRow) continue;
                var serviceId = Convert.ToInt32(row.Cells[0].Value);
                var servicePrice = _context.services.Find(serviceId).Price;
                totalPrice += servicePrice;
            }

            totalPrice += 1000;
            return totalPrice;
        }
    }
}
