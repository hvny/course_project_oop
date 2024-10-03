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
using Component = IS_v2.classes.Component;

namespace IS_v2.forms
{
    public partial class AddDeliveryForm : Form
    {
        private Form _parentForm;
        private AppContext _context;
        private List<DeliveryComponent> newDeliveryComponents;

        public AddDeliveryForm(AppContext context, Form parentForm)
        {
            InitializeComponent();
            _context = context;
            _parentForm = parentForm;
            newDeliveryComponents = new List<DeliveryComponent>();
            LoadComponentsComboBox();
            SetupDataGridView();
            this.FormClosed += addDeliveryForm_FormClosed;

        }

        private void SetupDataGridView()
        {
            dataGridViewDeliveryComponents.Columns.Clear();

            dataGridViewDeliveryComponents.Columns.Add("ComponentId", "ID детали");
            dataGridViewDeliveryComponents.Columns.Add("ComponentName", "Название детали");
            dataGridViewDeliveryComponents.Columns.Add("Quantity", "Количество");
            dataGridViewDeliveryComponents.Columns.Add("Price", "Цена за шт.");

            dataGridViewDeliveryComponents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadComponentsComboBox()
        {
            var components = _context.components.ToList();
            comboBoxComponents.DataSource = components;
            comboBoxComponents.DisplayMember = "Name";
            comboBoxComponents.ValueMember = "ComponentId";
        }

        private void buttonAddComponentToDelivery_Click(object sender, EventArgs e)
        {
            if (comboBoxComponents.SelectedItem == null || numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Пожалуйста, выберите товар и введите количество.");
                return;
            }

            var selectedComponent = (Component)comboBoxComponents.SelectedItem;
            int quantity = (int)numericUpDownQuantity.Value;

            var deliveryComponent = new DeliveryComponent
            {
                ComponentId = selectedComponent.ComponentId,
                Component = selectedComponent,
                Quantity = quantity,
                Price = selectedComponent.Price
            };

            newDeliveryComponents.Add(deliveryComponent);

            dataGridViewDeliveryComponents.Rows.Add(
                deliveryComponent.ComponentId,
                selectedComponent.Name,
                deliveryComponent.Quantity,
                deliveryComponent.Price
            );
        }

        private void buttonAddDelivery_Click(object sender, EventArgs e)
        {

            if (newDeliveryComponents.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один товар в поставку.");
                return;
            }

            DateTime selectedDate = dateTimePickerExpectedDate.Value;
            DateTime utcDate = DateTime.SpecifyKind(selectedDate, DateTimeKind.Utc);

            // Создаем новую поставку без указания DeliveryId, так как оно должно генерироваться автоматически
            var newDelivery = new Delivery
            {
                DeliveryDate = utcDate,
                Status = "Заказана"
            };

            _context.deliveries.Add(newDelivery);
            _context.SaveChanges();

            foreach (var deliveryComponent in newDeliveryComponents)
            {
                deliveryComponent.DeliveryId = newDelivery.DeliveryId;
                _context.delivery_components.Add(deliveryComponent);
            }

            _context.SaveChanges();

            MessageBox.Show("Поставка успешно добавлена!");
            this.Close();
        }

        private void addDeliveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_parentForm is Form1 mainForm)
            {
                mainForm.loadDeliveries();
            }
        }
    }
}
