using IS_v2.classes;
using IS_v2.contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AppContext = IS_v2.contexts.AppContext;

namespace IS_v2.forms
{
    public partial class CheckDeliveryForm : Form
    {

        private AppContext _context;
        private int _deliveryId;
        private Form _parentForm;
        public CheckDeliveryForm(AppContext context, int deliveryId, Form parentForm)
        {
            InitializeComponent();
            _context = context;
            _deliveryId = deliveryId;
            _parentForm = parentForm;
            LoadDeliveryDetails();
            this.FormClosed += CheckDeliveryForm_FormClosed;
        }

        private void LoadDeliveryDetails()
        {
            var delivery = _context.deliveries
                .Include(d => d.DeliveryComponents)
                .ThenInclude(dc => dc.Component)
                .FirstOrDefault(d => d.DeliveryId == _deliveryId);


            if (delivery != null)
            {
                double deliveryTotalPrice = 0.0;

                dataGridViewDeliveryComponents.Rows.Clear();
        
                textBoxDeliveryId.Text = delivery.DeliveryId.ToString();
                textBoxDeliveryDate.Text = delivery.DeliveryDate.ToLocalTime().ToString("yyyy-MM-dd");
                comboBoxDeliveryStatus.Text = delivery.Status;
                foreach (var component in delivery.DeliveryComponents)
                {
                    dataGridViewDeliveryComponents.Rows.Add(
                        component.ComponentId,
                        component.Component.Name,
                        component.Quantity,
                        (component.Price / component.Quantity)
                    );

                    deliveryTotalPrice += Convert.ToDouble(component.Price);
                }
                textBoxDeliveryTotalPrice.Text = deliveryTotalPrice.ToString();

            }
        }

        private bool ValidateDate(string date)
        {
            DateTime parsedDate;
            return DateTime.TryParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
        }

        private bool validateFields()
        {
            if (!ValidateDate(textBoxDeliveryDate.Text))
            {
                MessageBox.Show("Неверный формат даты. Используйте формат yyyy-MM-dd.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxDeliveryStatus.Text) || !comboBoxDeliveryStatus.Items.Contains(comboBoxDeliveryStatus.Text))
            {
                MessageBox.Show("Неверное значение статуса.");
                return false;
            }

            return true;
        }

        private void buttonEditDelivery_Click(object sender, EventArgs e)
        {
            if (!validateFields())
            {
                return;
            }

            var delivery = _context.deliveries
                .Include(d => d.DeliveryComponents)
                .ThenInclude(dc => dc.Component)
                .FirstOrDefault(d => d.DeliveryId == _deliveryId);

            if (delivery != null)
            {
                delivery.DeliveryDate = DateTime.ParseExact(textBoxDeliveryDate.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToUniversalTime();
                string newStatus = comboBoxDeliveryStatus.Text;

                if (newStatus == "Доставлена" && delivery.Status != "Доставлена")
                {
                    foreach (var component in delivery.DeliveryComponents)
                    {
                        var dbComponent = _context.components.FirstOrDefault(c => c.ComponentId == component.ComponentId);
                        if (dbComponent != null)
                        {
                            dbComponent.Quantity += component.Quantity;
                        }
                    }
                    MessageBox.Show("Поставка доставлена и количество компонентов обновлено.");
                }

                delivery.Status = newStatus;
                _context.SaveChanges();
                MessageBox.Show("Изменения сохранены.");
                this.Close();
            }
        }
    

        private void CheckDeliveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadDeliveries();
                mainForm.loadComponents();
            }
        }
    }
}
