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
using Component = IS_v2.classes.Component;

namespace IS_v2.forms
{
    public partial class AddComponentForm : Form
    {
        private AppContext _context;
        private Form _parentForm;
        public AddComponentForm(AppContext context, Form parentForm)
        {
            InitializeComponent();
            _context = context;
            _parentForm = parentForm;
            this.FormClosed += addComponentForm_FormClosed;
        }

        private void addComponentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadComponents();
            }
        }
        private void buttonAddNewComponent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxComponentName.Text) ||
                numericUpDownQuantity.Value <= 0 ||
                string.IsNullOrWhiteSpace(textBoxPriceForOne.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBoxPriceForOne.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную цену (число больше нуля).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newComponent = new Component
                {
                    Name = textBoxComponentName.Text,
                    Quantity = (int)numericUpDownQuantity.Value,
                    Price = price
                };

                _context.components.Add(newComponent);
                _context.SaveChanges();

                MessageBox.Show($"Компонент {newComponent.Name} успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении компонента: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
