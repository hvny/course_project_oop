using IS_v2.contexts;

namespace IS_v2
{
    public partial class Form1 : Form
    {
        private EmployeeContext _employeeContext;
        public Form1()
        {
            InitializeComponent();
            _employeeContext = new EmployeeContext();
        }

        private void buttonSearchEmpl_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddEmpl_Click(object sender, EventArgs e)
        {
            AddEmplForm addEmplFrom = new AddEmplForm();
            addEmplFrom.ShowDialog();
        }

       private void loavEmployees()
        {
            var employees = _employeeContext.Employees.ToList();

        }
    }
}
