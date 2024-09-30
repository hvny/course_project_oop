using AppContext = IS_v2.contexts.AppContext;

namespace IS_v2
{
    public partial class Form1 : Form
    {
        private AppContext _context;
        private AddEmplForm addEmplForm;
        public Form1()
        {
            InitializeComponent();
            InitializeAddEmplForm();
            _context = new AppContext();
            loadEmployees();
        }

        private void InitializeAddEmplForm()
        {
            addEmplForm = new AddEmplForm();
            addEmplForm.FormClosed += addEmplForm_FormClosed;
        }

        private void buttonAddEmpl_Click(object sender, EventArgs e)
        {
            addEmplForm.ShowDialog();
        }

        private void addEmplForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadEmployees();

        }

        private void loadEmployees()
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

            if (employees.Count > 0 )
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

        private void loadComponents()
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
                        component.Quantity
                    );
                }
            }
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

        private void dataGridViewEmpl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
