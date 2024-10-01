using IS_v2.classes;
using System.Data;
using System.Text.RegularExpressions;
using AppContext = IS_v2.contexts.AppContext;

namespace IS_v2
{
    public partial class AddEmplForm : Form
    {

        private AppContext _context;
        public Employee NewEmployee { get; set; }
        private Form _parentForm;

        public AddEmplForm(Form parentForm)
        {
            InitializeComponent();
            _context = new AppContext();
            _parentForm = parentForm;
            loadPositions();
            this.FormClosed += AddEmplForm_FormClosed;

        }

        private void loadPositions()
        {
            var positions = _context.positions.Select(p => p.Name).ToList();
            comboBoxPosition.DataSource = positions;
        }

        private bool validateFields()
        {
            if (!Regex.IsMatch(textBoxName.Text, @"^[а-яА-Яa-zA-Z]+$"))
            {
                MessageBox.Show("Имя должно содержать только буквы.");
                return false;
            }
            if (!Regex.IsMatch(textBoxLastName.Text, @"^[а-яА-Яa-zA-Z]+$"))
            {
                MessageBox.Show("Фамилия должна содержать только буквы.");
                return false;
            }
            if (!string.IsNullOrEmpty(textBoxMidName.Text) && !Regex.IsMatch(textBoxMidName.Text, @"^[а-яА-Яa-zA-Z]+$"))
            {
                MessageBox.Show("Отчество должно содержать только буквы.");
                return false;
            }
            if (!Regex.IsMatch(textBoxPhoneNumber.Text, @"^\d+$"))
            {
                return false;
            }
            if (comboBoxPosition.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите должность.");
                return false;
            }

            return true;
        }

        private void buttonAddNewEmpl_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                return;
            }

            NewEmployee = new Employee
            {
                        FirstName = textBoxName.Text,
                        LastName = textBoxLastName.Text,
                        MiddleName = textBoxMidName.Text,
                        PhoneNumber = textBoxPhoneNumber.Text,
                        PositionId = _context.positions.FirstOrDefault(p => p.Name == comboBoxPosition.Text).PositionId
            };
            
            _context.employees.Add(NewEmployee);
            _context.SaveChanges();
            MessageBox.Show("Сотрудник добавлен.");
            this.Close();
        }

        private void AddEmplForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadEmployees();
            }
        }
    }
}
