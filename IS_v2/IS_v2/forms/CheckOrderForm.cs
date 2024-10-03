using IS_v2.classes;
using Microsoft.EntityFrameworkCore;
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

namespace IS_v2
{
    public partial class CheckOrderForm : Form
    {
        private AppContext _context;
        private Form _parentForm;
        private int _orderId;
        public CheckOrderForm(AppContext context, Form parentForm, int orderId)
        {
            InitializeComponent();
            _context = context;
            _parentForm = parentForm;
            _orderId = orderId;
            loadOrderDetails();
            this.FormClosed += checkOrderForm_FormClosed;
        }

        private void checkOrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadOrders();
            }
        }

        private void loadOrderDetails()
        {
            dataGridViewServices.Rows.Clear();
            dataGridViewComponents.Rows.Clear();

            var order = _context.orders
                                .Include(o => o.User)
                                .FirstOrDefault(o => o.OrderId == _orderId);

            var services = _context.order_services
                           .Where(os => os.OrderId == _orderId)
                           .Include(os => os.Service) 
                           .Select(os => os.Service)
                           .ToList();

            var components = _context.service_components
                             .Where(sc => services.Select(s => s.ServiceId).Contains(sc.ServiceId))
                             .Include(sc => sc.Component)
                             .Select(sc => new
                             {
                                 sc.Component.ComponentId,
                                 sc.Component.Name,
                                 sc.Quantity
                             })
                             .ToList();

            foreach (var service in services)
            {
                dataGridViewServices.Rows.Add(
                    service.ServiceId,
                    service.Name
                );
            }

            foreach (var component in components)
            {
                dataGridViewComponents.Rows.Add(
                    component.ComponentId,
                    component.Name,
                    component.Quantity
                );
            }

            textBoxId.Text = order.OrderId.ToString();
            textBoxCreatedAt.Text = order.CreatedAt.ToString("g");
            textBoxTotalPrice.Text = order.TotalPrice.ToString("F2");
            textBoxDescription.Text = order.Description;
            textBoxDeviceName.Text = order.DeviceName;
            textBoxUserName.Text = order.User.Name;
            textBoxUserPhoneNum.Text = order.User.PhoneNumber;

            comboBoxStatus.Items.AddRange(new string[] { "Создан", "В работе", "Завершён" });
            comboBoxStatus.SelectedItem = order.Status;

            comboBoxPaymentMethod.Items.AddRange(new string[] { "Наличные", "Карта" });
            comboBoxPaymentMethod.SelectedItem = order.PaymentMethod;
            
            if (order.Status == "Завершён")
            {
                SetReadOnlyModeForControls();

                if (order.FinishedAt.HasValue)
                {
                    labelFinishedAt.Text = $"Заказ завершён {order.FinishedAt.Value:g}";
                    labelFinishedAt.Visible = true;
                }
            }
        }

        private void buttonEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                var order = _context.orders.FirstOrDefault(o => o.OrderId == _orderId);
                if (order == null)
                {
                    MessageBox.Show("Заказ не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                order.Status = comboBoxStatus.SelectedItem.ToString();
                order.Description = textBoxDescription.Text;
                order.DeviceName = textBoxDeviceName.Text;
                order.PaymentMethod = comboBoxPaymentMethod.SelectedItem.ToString();

                if (order.Status == "Завершён" && order.FinishedAt == null)
                {
                    order.FinishedAt = DateTime.UtcNow;
                }

                var user = _context.users.FirstOrDefault(u => u.UserId == order.UserId);
                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user.Name = textBoxUserName.Text;
                user.PhoneNumber = textBoxUserPhoneNum.Text;

                _context.SaveChanges();

                MessageBox.Show("Изменения успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetReadOnlyModeForControls()
        {
            textBoxDescription.ReadOnly = true;
            textBoxDeviceName.ReadOnly = true;
            textBoxUserName.ReadOnly = true;
            textBoxUserPhoneNum.ReadOnly = true;

            comboBoxStatus.Enabled = false;
            comboBoxPaymentMethod.Enabled = false;

            dataGridViewServices.ReadOnly = true;
            dataGridViewComponents.ReadOnly = true;

            buttonEditOrder.Enabled = false;
        }
    }
}
