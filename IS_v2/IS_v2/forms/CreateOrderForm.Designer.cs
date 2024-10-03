namespace IS_v2.forms
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxUser = new GroupBox();
            comboBoxPaymentMethod = new ComboBox();
            label5 = new Label();
            textBoxDescription = new TextBox();
            textBoxDeviceName = new TextBox();
            label4 = new Label();
            textBoxClientName = new TextBox();
            textBoxPhoneNum = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBoxServices = new GroupBox();
            buttonAddServiceToOrder = new Button();
            comboBoxServices = new ComboBox();
            groupBoxComponents = new GroupBox();
            numericUpDownComponentsQuantity = new NumericUpDown();
            comboBoxComponents = new ComboBox();
            buttonAddComponentToOrder = new Button();
            dataGridViewOrderServices = new DataGridView();
            order_service_id = new DataGridViewTextBoxColumn();
            order_service_name = new DataGridViewTextBoxColumn();
            order_service_price = new DataGridViewTextBoxColumn();
            dataGridViewOrderComponents = new DataGridView();
            order_component_id = new DataGridViewTextBoxColumn();
            order_component_name = new DataGridViewTextBoxColumn();
            order_component_quantity = new DataGridViewTextBoxColumn();
            order_component_price = new DataGridViewTextBoxColumn();
            buttonAddNewOrder = new Button();
            groupBoxUser.SuspendLayout();
            groupBoxServices.SuspendLayout();
            groupBoxComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownComponentsQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderServices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderComponents).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUser
            // 
            groupBoxUser.Controls.Add(comboBoxPaymentMethod);
            groupBoxUser.Controls.Add(label5);
            groupBoxUser.Controls.Add(textBoxDescription);
            groupBoxUser.Controls.Add(textBoxDeviceName);
            groupBoxUser.Controls.Add(label4);
            groupBoxUser.Controls.Add(textBoxClientName);
            groupBoxUser.Controls.Add(textBoxPhoneNum);
            groupBoxUser.Controls.Add(label3);
            groupBoxUser.Controls.Add(label1);
            groupBoxUser.Controls.Add(label2);
            groupBoxUser.Location = new Point(12, 12);
            groupBoxUser.Name = "groupBoxUser";
            groupBoxUser.Size = new Size(359, 270);
            groupBoxUser.TabIndex = 0;
            groupBoxUser.TabStop = false;
            groupBoxUser.Text = "Клиент";
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(6, 166);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(151, 28);
            comboBoxPaymentMethod.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 143);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 7;
            label5.Text = "Метод оплаты";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(172, 50);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(181, 202);
            textBoxDescription.TabIndex = 6;
            // 
            // textBoxDeviceName
            // 
            textBoxDeviceName.Location = new Point(6, 225);
            textBoxDeviceName.Name = "textBoxDeviceName";
            textBoxDeviceName.Size = new Size(151, 27);
            textBoxDeviceName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 27);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Описание";
            // 
            // textBoxClientName
            // 
            textBoxClientName.Location = new Point(6, 108);
            textBoxClientName.Name = "textBoxClientName";
            textBoxClientName.Size = new Size(151, 27);
            textBoxClientName.TabIndex = 4;
            // 
            // textBoxPhoneNum
            // 
            textBoxPhoneNum.Location = new Point(6, 50);
            textBoxPhoneNum.Name = "textBoxPhoneNum";
            textBoxPhoneNum.Size = new Size(151, 27);
            textBoxPhoneNum.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 202);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 5;
            label3.Text = "Устройство";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 3;
            label1.Text = "Номер телефона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "Имя";
            // 
            // groupBoxServices
            // 
            groupBoxServices.Controls.Add(buttonAddServiceToOrder);
            groupBoxServices.Controls.Add(comboBoxServices);
            groupBoxServices.Location = new Point(450, 12);
            groupBoxServices.Name = "groupBoxServices";
            groupBoxServices.Size = new Size(214, 125);
            groupBoxServices.TabIndex = 1;
            groupBoxServices.TabStop = false;
            groupBoxServices.Text = "Услуги";
            // 
            // buttonAddServiceToOrder
            // 
            buttonAddServiceToOrder.Location = new Point(6, 86);
            buttonAddServiceToOrder.Name = "buttonAddServiceToOrder";
            buttonAddServiceToOrder.Size = new Size(202, 29);
            buttonAddServiceToOrder.TabIndex = 1;
            buttonAddServiceToOrder.Text = "Добавить";
            buttonAddServiceToOrder.UseVisualStyleBackColor = true;
            buttonAddServiceToOrder.Click += buttonAddServiceToOrder_Click;
            // 
            // comboBoxServices
            // 
            comboBoxServices.FormattingEnabled = true;
            comboBoxServices.Location = new Point(6, 38);
            comboBoxServices.Name = "comboBoxServices";
            comboBoxServices.Size = new Size(202, 28);
            comboBoxServices.TabIndex = 0;
            // 
            // groupBoxComponents
            // 
            groupBoxComponents.Controls.Add(numericUpDownComponentsQuantity);
            groupBoxComponents.Controls.Add(comboBoxComponents);
            groupBoxComponents.Controls.Add(buttonAddComponentToOrder);
            groupBoxComponents.Location = new Point(450, 157);
            groupBoxComponents.Name = "groupBoxComponents";
            groupBoxComponents.Size = new Size(214, 125);
            groupBoxComponents.TabIndex = 2;
            groupBoxComponents.TabStop = false;
            groupBoxComponents.Text = "Детали";
            // 
            // numericUpDownComponentsQuantity
            // 
            numericUpDownComponentsQuantity.Location = new Point(158, 37);
            numericUpDownComponentsQuantity.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDownComponentsQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownComponentsQuantity.Name = "numericUpDownComponentsQuantity";
            numericUpDownComponentsQuantity.Size = new Size(50, 27);
            numericUpDownComponentsQuantity.TabIndex = 2;
            numericUpDownComponentsQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxComponents
            // 
            comboBoxComponents.FormattingEnabled = true;
            comboBoxComponents.Location = new Point(6, 36);
            comboBoxComponents.Name = "comboBoxComponents";
            comboBoxComponents.Size = new Size(143, 28);
            comboBoxComponents.TabIndex = 1;
            // 
            // buttonAddComponentToOrder
            // 
            buttonAddComponentToOrder.Location = new Point(6, 90);
            buttonAddComponentToOrder.Name = "buttonAddComponentToOrder";
            buttonAddComponentToOrder.Size = new Size(202, 29);
            buttonAddComponentToOrder.TabIndex = 0;
            buttonAddComponentToOrder.Text = "Добавить";
            buttonAddComponentToOrder.UseVisualStyleBackColor = true;
            buttonAddComponentToOrder.Click += buttonAddComponentToOrder_Click;
            // 
            // dataGridViewOrderServices
            // 
            dataGridViewOrderServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderServices.Columns.AddRange(new DataGridViewColumn[] { order_service_id, order_service_name, order_service_price });
            dataGridViewOrderServices.Location = new Point(18, 304);
            dataGridViewOrderServices.Name = "dataGridViewOrderServices";
            dataGridViewOrderServices.RowHeadersWidth = 51;
            dataGridViewOrderServices.Size = new Size(332, 188);
            dataGridViewOrderServices.TabIndex = 3;
            // 
            // order_service_id
            // 
            order_service_id.HeaderText = "id";
            order_service_id.MinimumWidth = 6;
            order_service_id.Name = "order_service_id";
            order_service_id.Width = 30;
            // 
            // order_service_name
            // 
            order_service_name.HeaderText = "Наименование";
            order_service_name.MinimumWidth = 6;
            order_service_name.Name = "order_service_name";
            order_service_name.Width = 125;
            // 
            // order_service_price
            // 
            order_service_price.HeaderText = "Стоимость";
            order_service_price.MinimumWidth = 6;
            order_service_price.Name = "order_service_price";
            order_service_price.Width = 125;
            // 
            // dataGridViewOrderComponents
            // 
            dataGridViewOrderComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderComponents.Columns.AddRange(new DataGridViewColumn[] { order_component_id, order_component_name, order_component_quantity, order_component_price });
            dataGridViewOrderComponents.Location = new Point(390, 304);
            dataGridViewOrderComponents.Name = "dataGridViewOrderComponents";
            dataGridViewOrderComponents.RowHeadersWidth = 51;
            dataGridViewOrderComponents.Size = new Size(342, 188);
            dataGridViewOrderComponents.TabIndex = 4;
            // 
            // order_component_id
            // 
            order_component_id.HeaderText = "id";
            order_component_id.MinimumWidth = 6;
            order_component_id.Name = "order_component_id";
            order_component_id.Width = 30;
            // 
            // order_component_name
            // 
            order_component_name.HeaderText = "Наименование";
            order_component_name.MinimumWidth = 6;
            order_component_name.Name = "order_component_name";
            order_component_name.Width = 125;
            // 
            // order_component_quantity
            // 
            order_component_quantity.HeaderText = "Кол-во";
            order_component_quantity.MinimumWidth = 6;
            order_component_quantity.Name = "order_component_quantity";
            order_component_quantity.Width = 80;
            // 
            // order_component_price
            // 
            order_component_price.HeaderText = "Цена за шт.";
            order_component_price.MinimumWidth = 6;
            order_component_price.Name = "order_component_price";
            order_component_price.Width = 80;
            // 
            // buttonAddNewOrder
            // 
            buttonAddNewOrder.Location = new Point(564, 507);
            buttonAddNewOrder.Name = "buttonAddNewOrder";
            buttonAddNewOrder.Size = new Size(168, 39);
            buttonAddNewOrder.TabIndex = 5;
            buttonAddNewOrder.Text = "Создать заказ";
            buttonAddNewOrder.UseVisualStyleBackColor = true;
            buttonAddNewOrder.Click += buttonAddNewOrder_Click;
            // 
            // CreateOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 548);
            Controls.Add(buttonAddNewOrder);
            Controls.Add(dataGridViewOrderComponents);
            Controls.Add(dataGridViewOrderServices);
            Controls.Add(groupBoxComponents);
            Controls.Add(groupBoxServices);
            Controls.Add(groupBoxUser);
            Name = "CreateOrderForm";
            Text = "Создать заказ";
            Load += CreateOrderForm_Load;
            groupBoxUser.ResumeLayout(false);
            groupBoxUser.PerformLayout();
            groupBoxServices.ResumeLayout(false);
            groupBoxComponents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownComponentsQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderServices).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderComponents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUser;
        private TextBox textBoxClientName;
        private TextBox textBoxPhoneNum;
        private Label label1;
        private Label label2;
        private GroupBox groupBoxServices;
        private GroupBox groupBoxComponents;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxDescription;
        private TextBox textBoxDeviceName;
        private ComboBox comboBoxPaymentMethod;
        private Button buttonAddServiceToOrder;
        private ComboBox comboBoxServices;
        private NumericUpDown numericUpDownComponentsQuantity;
        private ComboBox comboBoxComponents;
        private Button buttonAddComponentToOrder;
        private DataGridView dataGridViewOrderServices;
        private DataGridView dataGridViewOrderComponents;
        private Button buttonAddNewOrder;
        private DataGridViewTextBoxColumn order_service_id;
        private DataGridViewTextBoxColumn order_service_name;
        private DataGridViewTextBoxColumn order_service_price;
        private DataGridViewTextBoxColumn order_component_id;
        private DataGridViewTextBoxColumn order_component_name;
        private DataGridViewTextBoxColumn order_component_quantity;
        private DataGridViewTextBoxColumn order_component_price;
    }
}