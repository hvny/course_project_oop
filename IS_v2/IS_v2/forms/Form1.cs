using IS_v2.forms;
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

        private void buttonAddEmpl_Click(object sender, EventArgs e)
        {
            AddEmplForm addEmplForm = new AddEmplForm(this);
            addEmplForm.ShowDialog();
        }

        private void loadAllData()
        {
            loadEmployees();
            loadComponents();
            loadDeliveries();
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

            var deliveries = (from d in _context.deliveries
                              select new
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

        private void buttonAddDelivery_Click(object sender, EventArgs e)
        {
            AddDeliveryForm addDeliveryForm = new AddDeliveryForm(_context, this);
            addDeliveryForm.ShowDialog();
        }
    }
}
