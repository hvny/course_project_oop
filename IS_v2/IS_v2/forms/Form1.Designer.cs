namespace IS_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPageOrders = new TabPage();
            buttonGoToOrder = new Button();
            buttonAddOrder = new Button();
            label2 = new Label();
            dataGridViewOrders = new DataGridView();
            order_id = new DataGridViewTextBoxColumn();
            order_createdAt = new DataGridViewTextBoxColumn();
            order_status = new DataGridViewTextBoxColumn();
            order_price = new DataGridViewTextBoxColumn();
            order_device = new DataGridViewTextBoxColumn();
            order_userPhoneNumber = new DataGridViewTextBoxColumn();
            tabPageDeliveries = new TabPage();
            dataGridViewDeliveries = new DataGridView();
            delivery_id = new DataGridViewTextBoxColumn();
            components_list = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            buttonGoToDelivery = new Button();
            buttonAddDelivery = new Button();
            tabPageEmployees = new TabPage();
            buttonDeleteEmpl = new Button();
            buttonAddEmpl = new Button();
            dataGridViewEmpl = new DataGridView();
            empl_id = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            middle_name = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabPageWarehouse = new TabPage();
            dataGridViewComponents = new DataGridView();
            ComponentId = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPageDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeliveries).BeginInit();
            tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpl).BeginInit();
            tabPageWarehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComponents).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOrders);
            tabControl1.Controls.Add(tabPageDeliveries);
            tabControl1.Controls.Add(tabPageEmployees);
            tabControl1.Controls.Add(tabPageWarehouse);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(916, 436);
            tabControl1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(buttonGoToOrder);
            tabPageOrders.Controls.Add(buttonAddOrder);
            tabPageOrders.Controls.Add(label2);
            tabPageOrders.Controls.Add(dataGridViewOrders);
            tabPageOrders.Location = new Point(4, 29);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.Padding = new Padding(3);
            tabPageOrders.Size = new Size(908, 403);
            tabPageOrders.TabIndex = 0;
            tabPageOrders.Text = "Заказы";
            tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // buttonGoToOrder
            // 
            buttonGoToOrder.Location = new Point(737, 98);
            buttonGoToOrder.Name = "buttonGoToOrder";
            buttonGoToOrder.Size = new Size(154, 37);
            buttonGoToOrder.TabIndex = 3;
            buttonGoToOrder.Text = "Перейти к заказу";
            buttonGoToOrder.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Location = new Point(737, 39);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(154, 37);
            buttonAddOrder.TabIndex = 2;
            buttonAddOrder.Text = "Создать заказ";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(6, 4);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Список заказов";
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Columns.AddRange(new DataGridViewColumn[] { order_id, order_createdAt, order_status, order_price, order_device, order_userPhoneNumber });
            dataGridViewOrders.Location = new Point(6, 39);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(712, 358);
            dataGridViewOrders.TabIndex = 0;
            // 
            // order_id
            // 
            order_id.HeaderText = "id";
            order_id.MinimumWidth = 6;
            order_id.Name = "order_id";
            order_id.Width = 40;
            // 
            // order_createdAt
            // 
            order_createdAt.HeaderText = "Создан";
            order_createdAt.MinimumWidth = 6;
            order_createdAt.Name = "order_createdAt";
            order_createdAt.Width = 75;
            // 
            // order_status
            // 
            order_status.HeaderText = "Статус";
            order_status.MinimumWidth = 6;
            order_status.Name = "order_status";
            order_status.Width = 95;
            // 
            // order_price
            // 
            order_price.HeaderText = "Общая стоимость";
            order_price.MinimumWidth = 6;
            order_price.Name = "order_price";
            order_price.Width = 125;
            // 
            // order_device
            // 
            order_device.HeaderText = "Устройство";
            order_device.MinimumWidth = 6;
            order_device.Name = "order_device";
            order_device.Width = 125;
            // 
            // order_userPhoneNumber
            // 
            order_userPhoneNumber.HeaderText = "Номер телефона клиента";
            order_userPhoneNumber.MinimumWidth = 6;
            order_userPhoneNumber.Name = "order_userPhoneNumber";
            order_userPhoneNumber.Width = 125;
            // 
            // tabPageDeliveries
            // 
            tabPageDeliveries.Controls.Add(dataGridViewDeliveries);
            tabPageDeliveries.Controls.Add(buttonGoToDelivery);
            tabPageDeliveries.Controls.Add(buttonAddDelivery);
            tabPageDeliveries.Location = new Point(4, 29);
            tabPageDeliveries.Name = "tabPageDeliveries";
            tabPageDeliveries.Padding = new Padding(3);
            tabPageDeliveries.Size = new Size(908, 403);
            tabPageDeliveries.TabIndex = 1;
            tabPageDeliveries.Text = "Поставки";
            tabPageDeliveries.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDeliveries
            // 
            dataGridViewDeliveries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeliveries.Columns.AddRange(new DataGridViewColumn[] { delivery_id, components_list, date, status });
            dataGridViewDeliveries.Location = new Point(6, 30);
            dataGridViewDeliveries.Name = "dataGridViewDeliveries";
            dataGridViewDeliveries.RowHeadersWidth = 51;
            dataGridViewDeliveries.Size = new Size(685, 367);
            dataGridViewDeliveries.TabIndex = 2;
            // 
            // delivery_id
            // 
            delivery_id.HeaderText = "id";
            delivery_id.MinimumWidth = 6;
            delivery_id.Name = "delivery_id";
            delivery_id.Width = 125;
            // 
            // components_list
            // 
            components_list.HeaderText = "Детали";
            components_list.MinimumWidth = 6;
            components_list.Name = "components_list";
            components_list.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "Дата прибытия";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Статус";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.Width = 125;
            // 
            // buttonGoToDelivery
            // 
            buttonGoToDelivery.Location = new Point(715, 91);
            buttonGoToDelivery.Name = "buttonGoToDelivery";
            buttonGoToDelivery.Size = new Size(171, 40);
            buttonGoToDelivery.TabIndex = 1;
            buttonGoToDelivery.Text = "Перейти к поставке";
            buttonGoToDelivery.UseVisualStyleBackColor = true;
            buttonGoToDelivery.Click += buttonGoToDelivery_Click;
            // 
            // buttonAddDelivery
            // 
            buttonAddDelivery.Location = new Point(715, 30);
            buttonAddDelivery.Name = "buttonAddDelivery";
            buttonAddDelivery.Size = new Size(171, 40);
            buttonAddDelivery.TabIndex = 0;
            buttonAddDelivery.Text = "Добавить поставку";
            buttonAddDelivery.UseVisualStyleBackColor = true;
            buttonAddDelivery.Click += buttonAddDelivery_Click;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.Controls.Add(buttonDeleteEmpl);
            tabPageEmployees.Controls.Add(buttonAddEmpl);
            tabPageEmployees.Controls.Add(dataGridViewEmpl);
            tabPageEmployees.Controls.Add(label1);
            tabPageEmployees.Location = new Point(4, 29);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Size = new Size(908, 403);
            tabPageEmployees.TabIndex = 2;
            tabPageEmployees.Text = "Сотрудники";
            tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmpl
            // 
            buttonDeleteEmpl.Location = new Point(722, 356);
            buttonDeleteEmpl.Name = "buttonDeleteEmpl";
            buttonDeleteEmpl.Size = new Size(169, 41);
            buttonDeleteEmpl.TabIndex = 5;
            buttonDeleteEmpl.Text = "Удалить сотрудника";
            buttonDeleteEmpl.UseVisualStyleBackColor = true;
            buttonDeleteEmpl.Click += buttonDeleteEmpl_Click;
            // 
            // buttonAddEmpl
            // 
            buttonAddEmpl.Location = new Point(722, 35);
            buttonAddEmpl.Name = "buttonAddEmpl";
            buttonAddEmpl.Size = new Size(169, 47);
            buttonAddEmpl.TabIndex = 3;
            buttonAddEmpl.Text = "Добавить сотрудника";
            buttonAddEmpl.UseVisualStyleBackColor = true;
            buttonAddEmpl.Click += buttonAddEmpl_Click;
            // 
            // dataGridViewEmpl
            // 
            dataGridViewEmpl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpl.Columns.AddRange(new DataGridViewColumn[] { empl_id, position, first_name, last_name, middle_name, phone_number });
            dataGridViewEmpl.Location = new Point(3, 35);
            dataGridViewEmpl.Name = "dataGridViewEmpl";
            dataGridViewEmpl.RowHeadersWidth = 51;
            dataGridViewEmpl.Size = new Size(700, 365);
            dataGridViewEmpl.TabIndex = 1;
            // 
            // empl_id
            // 
            empl_id.HeaderText = "id";
            empl_id.MinimumWidth = 3;
            empl_id.Name = "empl_id";
            empl_id.Width = 50;
            // 
            // position
            // 
            position.HeaderText = "Должность";
            position.MinimumWidth = 6;
            position.Name = "position";
            position.Width = 125;
            // 
            // first_name
            // 
            first_name.HeaderText = "Имя";
            first_name.MinimumWidth = 6;
            first_name.Name = "first_name";
            first_name.Width = 125;
            // 
            // last_name
            // 
            last_name.HeaderText = "Фамилия";
            last_name.MinimumWidth = 6;
            last_name.Name = "last_name";
            last_name.Width = 125;
            // 
            // middle_name
            // 
            middle_name.HeaderText = "Отчество";
            middle_name.MinimumWidth = 6;
            middle_name.Name = "middle_name";
            middle_name.Width = 125;
            // 
            // phone_number
            // 
            phone_number.HeaderText = "Номер телефона";
            phone_number.MinimumWidth = 6;
            phone_number.Name = "phone_number";
            phone_number.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(258, 32);
            label1.TabIndex = 0;
            label1.Text = "Список сотрудников";
            // 
            // tabPageWarehouse
            // 
            tabPageWarehouse.Controls.Add(dataGridViewComponents);
            tabPageWarehouse.Controls.Add(label3);
            tabPageWarehouse.Location = new Point(4, 29);
            tabPageWarehouse.Name = "tabPageWarehouse";
            tabPageWarehouse.Size = new Size(908, 403);
            tabPageWarehouse.TabIndex = 3;
            tabPageWarehouse.Text = "Склад";
            tabPageWarehouse.UseVisualStyleBackColor = true;
            // 
            // dataGridViewComponents
            // 
            dataGridViewComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComponents.Columns.AddRange(new DataGridViewColumn[] { ComponentId, Name, Price, Quantity });
            dataGridViewComponents.Location = new Point(3, 35);
            dataGridViewComponents.Name = "dataGridViewComponents";
            dataGridViewComponents.RowHeadersWidth = 51;
            dataGridViewComponents.Size = new Size(730, 362);
            dataGridViewComponents.TabIndex = 1;
            // 
            // ComponentId
            // 
            ComponentId.HeaderText = "id";
            ComponentId.MinimumWidth = 6;
            ComponentId.Name = "ComponentId";
            ComponentId.Width = 125;
            // 
            // Name
            // 
            Name.HeaderText = "Наименование";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Цена за шт.";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Количество";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(224, 32);
            label3.TabIndex = 0;
            label3.Text = "Список запчастей";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 450);
            Controls.Add(tabControl1);
           // Name = "Form1";
            Text = "Сервис ремонта компьютерной техники";
            tabControl1.ResumeLayout(false);
            tabPageOrders.ResumeLayout(false);
            tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPageDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeliveries).EndInit();
            tabPageEmployees.ResumeLayout(false);
            tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpl).EndInit();
            tabPageWarehouse.ResumeLayout(false);
            tabPageWarehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComponents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageOrders;
        private TabPage tabPageDeliveries;
        private TabPage tabPageEmployees;
        private Button buttonAddEmpl;
        private DataGridView dataGridViewEmpl;
        private Label label1;
        private Button buttonDeleteEmpl;
        private Label label2;
        private DataGridView dataGridViewOrders;
        private Button buttonAddOrder;
        private Button buttonGoToOrder;
        private DataGridView dataGridViewDeliveries;
        private Button buttonGoToDelivery;
        private Button buttonAddDelivery;
        private DataGridViewTextBoxColumn empl_id;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn middle_name;
        private DataGridViewTextBoxColumn phone_number;
        private TabPage tabPageWarehouse;
        private DataGridView dataGridViewComponents;
        private Label label3;
        private DataGridViewTextBoxColumn ComponentId;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn delivery_id;
        private DataGridViewTextBoxColumn components_list;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn order_createdAt;
        private DataGridViewTextBoxColumn order_status;
        private DataGridViewTextBoxColumn order_price;
        private DataGridViewTextBoxColumn order_device;
        private DataGridViewTextBoxColumn order_userPhoneNumber;
    }
}
