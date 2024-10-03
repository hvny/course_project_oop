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
using Service = IS_v2.classes.Service;
namespace IS_v2.forms
{
    public partial class AddServiceForm : Form
    {
        private AppContext _context;
        private Form _parentForm;
        public AddServiceForm(AppContext context, Form parentForm)
        {
            InitializeComponent();
            _context = context;
            _parentForm = parentForm;
            this.FormClosed += addServiceForm_FormClosed;
        }

        private void addServiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadServices();
            }
        }

        private void buttonAddNewService_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxServiceName.Text) ||
                string.IsNullOrWhiteSpace(textBoxServiceDescription.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxServicePrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную цену (число больше нуля).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var newService = new Service
                {
                    Name = textBoxServiceName.Text,
                    Description = textBoxServiceDescription.Text,
                    Price = price
                };

                _context.services.Add(newService);
                _context.SaveChanges();

                MessageBox.Show($"Услуга {newService.Name} успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении услуги: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
