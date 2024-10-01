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

namespace IS_v2.forms
{
    public partial class AddDeliveryForm : Form
    {
        private Form _parentForm;
        private AppContext _context;

        public AddDeliveryForm(AppContext context, Form parentForm)
        {
            InitializeComponent();
            _context = context;

            _parentForm = parentForm;
        }

        private void AddDeliveryForm_Load(object sender, EventArgs e)
        {
            comboBoxComponents.Items.Clear();

            loadComponents();
        }

        private void loadComponents()
        {
            var components = _context.components.ToList();

           /* foreach (var component in components)
            {
                comboBoxComponents.Items.Add(new ComboBoxItem(component.Name, component.ComponentId));
            }*/
        }
    }
}
