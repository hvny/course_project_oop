using IS_v2.classes;
using IS_v2.forms;
using Microsoft.EntityFrameworkCore;
using AppContext = IS_v2.contexts.AppContext;

namespace IS_v2
{
    public partial class Form1 : Form
    {
        private AppContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new AppContext();
            loadAllData();
        }
        private void buttonAddComponent_Click(object sender, EventArgs e)
        {
            AddComponentForm addComponentForm = new AddComponentForm(_context, this);
            addComponentForm.ShowDialog();
        }

        private void buttonAddEmpl_Click(object sender, EventArgs e)
        {
            AddEmplForm addEmplForm = new AddEmplForm(this);
            addEmplForm.ShowDialog();
        }

        private void buttonAddDelivery_Click(object sender, EventArgs e)
        {
            AddDeliveryForm addDeliveryForm = new AddDeliveryForm(_context, this);
            addDeliveryForm.ShowDialog();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            CreateOrderForm createOrderForm = new CreateOrderForm(_context, this);
            createOrderForm.ShowDialog();
        }

        private void buttonAddService_Click(object sender, EventArgs e)
        {
            AddServiceForm addServiceForm = new AddServiceForm(_context, this);
            addServiceForm.ShowDialog();
        }

        private void loadAllData()
        {
            loadEmployees();
            loadComponents();
            loadDeliveries();
            loadOrders();
            loadServices();
        }

        public void loadServices()
        {
            dataGridViewServices.Rows.Clear();

            var services = _context.services.ToList();

            foreach (var service in services)
            {
                dataGridViewServices.Rows.Add(
                    service.ServiceId,
                    service.Name,
                    service.Description,
                    service.Price
                );
            }
        }

        public void loadEmployees()
        {
            dataGridViewEmpl.Rows.Clear();

            var employees = (from e in _context.employees
                             join p in _context.positions on e.PositionId equals p.PositionId
                             select new
                             {
                                 e.employeeId,
                                 Position = p.Name,
                                 e.FirstName,
                                 e.LastName,
                                 e.MiddleName,
                                 e.PhoneNumber
                             }).ToList();

            if (employees.Count > 0)
            {
                foreach (var employee in employees)
                {
                    dataGridViewEmpl.Rows.Add(
                        employee.employeeId,
                        employee.Position,
                        employee.FirstName,
                        employee.LastName,
                        employee.MiddleName,
                        employee.PhoneNumber
                    );
                }
            }
        }

        public void loadComponents()
        {
            dataGridViewComponents.Rows.Clear();

            var components = (from c in _context.components
                              select new
                              {
                                  c.ComponentId,
                                  c.Name,
                                  c.Price,
                                  c.Quantity
                              }).ToList();

            if (components.Count > 0)
            {
                foreach (var component in components)
                {
                    dataGridViewComponents.Rows.Add(
                        component.ComponentId,
                        component.Name,
                        component.Price,
                        component.Quantity
                    );
                }
            }
        }

        public void loadDeliveries()
        {
            dataGridViewDeliveries.Rows.Clear();
            var deliveries = _context.deliveries.Include(d => d.DeliveryComponents)
                .ThenInclude(dc => dc.Component)  // Загрузить связанные компоненты
                .Select(d => new
                {
                d.DeliveryId,
                d.DeliveryDate,
                d.Status,
                Components = d.DeliveryComponents.Select(dc => dc.Component.Name).ToList()
           }).ToList();
            

            if (deliveries.Count > 0)
            {
                foreach (var delivery in deliveries)
                {
                    string componentsList = string.Join(", ", delivery.Components);

                    int rowIndex = dataGridViewDeliveries.Rows.Add(
                        delivery.DeliveryId,
                        componentsList,
                        delivery.DeliveryDate.ToLocalTime().ToString("yyyy-MM-dd"),
                        delivery.Status
                    );

                    if (delivery.Status == "Доставлена")
                    {
                        deactivateDeliveryRow(rowIndex);
                    }
                }
            }
        }

        public void loadOrders()
        {
            dataGridViewOrders.Rows.Clear();

            var orders = _context.orders.Include(o => o.User).ToList();

            foreach (var order in orders)
            {
                // Проверяем, существует ли пользователь для заказа
                var userPhoneNumber = order.User != null ? order.User.PhoneNumber : "Не указан";

                dataGridViewOrders.Rows.Add(
                    order.OrderId,
                    order.CreatedAt,
                    order.Status,
                    order.TotalPrice,
                    order.DeviceName,
                    userPhoneNumber
                );
            }
        }
        private void deactivateDeliveryRow(int rowId)
        {
            DataGridViewRow row = dataGridViewDeliveries.Rows[rowId];
            row.DefaultCellStyle.ForeColor = Color.Gray;
            row.DefaultCellStyle.BackColor = Color.LightGray;
            row.ReadOnly = true;
        }


        private void buttonDeleteEmpl_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpl.SelectedRows.Count > 0)
            {
                int employeeId = Convert.ToInt32(dataGridViewEmpl.SelectedRows[0].Cells["empl_id"].Value);

                if (MessageBox.Show($"Вы уверены, что хотите удалить сотрудника с ID {employeeId}?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var employeeToDelete = _context.employees.Find(employeeId);
                    if (employeeToDelete != null)
                    {
                        _context.employees.Remove(employeeToDelete);
                        _context.SaveChanges();

                        loadEmployees();
                    }
                    else
                    {
                        MessageBox.Show($"Сотрудник с ID {employeeId} не найден.", "Ошибка");
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.");
            }
        }

        private void buttonGoToDelivery_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeliveries.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewDeliveries.SelectedRows[0];
                string status = selectedRow.Cells["Status"].Value.ToString();
                if (status == "Доставлена")
                {
                    MessageBox.Show("Эту поставку нельзя редактировать, так как она уже доставлена.");
                    return;
                }

                int deliveryId = (int)dataGridViewDeliveries.SelectedRows[0].Cells["delivery_id"].Value;

                var detailsForm = new CheckDeliveryForm(_context, deliveryId, this);
                detailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите поставку.");

            }
        }

        private void buttonDeleteComponent_Click(object sender, EventArgs e)
        {
            if (dataGridViewComponents.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите компонент для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewComponents.SelectedRows[0];
            var componentId = Convert.ToInt32(selectedRow.Cells["ComponentId"].Value);

            try
            {
                var componentToDelete = _context.components.Find(componentId);
                if (componentToDelete == null)
                {
                    MessageBox.Show($"Компонент с ID {componentId} не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.components.Remove(componentToDelete);
                _context.SaveChanges();

                MessageBox.Show($"Компонент {componentToDelete.Name} удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadComponents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении компонента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            if (dataGridViewServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите услугу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewServices.SelectedRows[0];
            var serviceId = Convert.ToInt32(selectedRow.Cells["ServiceId"].Value);

            try
            {
                var serviceToDelete = _context.services.Find(serviceId);
                if (serviceToDelete == null)
                {
                    MessageBox.Show($"Услуга с ID {serviceId} не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.services.Remove(serviceToDelete);
                _context.SaveChanges();

                MessageBox.Show($"Услуга {serviceToDelete.Name} удалена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении услуги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGoToOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value;

                var orderDetailsForm = new CheckOrderForm(_context, this, orderId);
                orderDetailsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите заказ.");

            }
        }
    }
}
