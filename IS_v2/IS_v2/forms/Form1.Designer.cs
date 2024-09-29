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
            buttonCreateOrder = new Button();
            label2 = new Label();
            dataGridViewOrders = new DataGridView();
            tabPageDeliveries = new TabPage();
            dataGridView1 = new DataGridView();
            buttonGoToDelivery = new Button();
            buttonCreateDelivery = new Button();
            tabPageEmployees = new TabPage();
            buttonDeleteEmpl = new Button();
            buttonAddEmpl = new Button();
            dataGridViewEmpl = new DataGridView();
            label1 = new Label();
            empl_id = new DataGridViewTextBoxColumn();
            position = new DataGridViewTextBoxColumn();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            middle_name = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tabPageDeliveries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpl).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageOrders);
            tabControl1.Controls.Add(tabPageDeliveries);
            tabControl1.Controls.Add(tabPageEmployees);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(916, 436);
            tabControl1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Controls.Add(buttonGoToOrder);
            tabPageOrders.Controls.Add(buttonCreateOrder);
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
            // buttonCreateOrder
            // 
            buttonCreateOrder.Location = new Point(737, 39);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(154, 37);
            buttonCreateOrder.TabIndex = 2;
            buttonCreateOrder.Text = "Создать заказ";
            buttonCreateOrder.UseVisualStyleBackColor = true;
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
            dataGridViewOrders.Location = new Point(6, 39);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.Size = new Size(712, 358);
            dataGridViewOrders.TabIndex = 0;
            // 
            // tabPageDeliveries
            // 
            tabPageDeliveries.Controls.Add(dataGridView1);
            tabPageDeliveries.Controls.Add(buttonGoToDelivery);
            tabPageDeliveries.Controls.Add(buttonCreateDelivery);
            tabPageDeliveries.Location = new Point(4, 29);
            tabPageDeliveries.Name = "tabPageDeliveries";
            tabPageDeliveries.Padding = new Padding(3);
            tabPageDeliveries.Size = new Size(908, 403);
            tabPageDeliveries.TabIndex = 1;
            tabPageDeliveries.Text = "Поставки";
            tabPageDeliveries.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 30);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(685, 367);
            dataGridView1.TabIndex = 2;
            // 
            // buttonGoToDelivery
            // 
            buttonGoToDelivery.Location = new Point(715, 91);
            buttonGoToDelivery.Name = "buttonGoToDelivery";
            buttonGoToDelivery.Size = new Size(171, 40);
            buttonGoToDelivery.TabIndex = 1;
            buttonGoToDelivery.Text = "Перейти к поставке";
            buttonGoToDelivery.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDelivery
            // 
            buttonCreateDelivery.Location = new Point(715, 30);
            buttonCreateDelivery.Name = "buttonCreateDelivery";
            buttonCreateDelivery.Size = new Size(171, 40);
            buttonCreateDelivery.TabIndex = 0;
            buttonCreateDelivery.Text = "Добавить поставку";
            buttonCreateDelivery.UseVisualStyleBackColor = true;
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
            // 
            // last_name
            // 
            last_name.HeaderText = "Фамилия";
            last_name.MinimumWidth = 6;
            last_name.Name = "last_name";
            // 
            // middle_name
            // 
            middle_name.HeaderText = "Отчество";
            middle_name.MinimumWidth = 6;
            middle_name.Name = "middle_name";
            // 
            // phone_number
            // 
            phone_number.HeaderText = "Номер телефона";
            phone_number.MinimumWidth = 6;
            phone_number.Name = "phone_number";
            phone_number.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Сервис ремонта компьютерной техники";
            tabControl1.ResumeLayout(false);
            tabPageOrders.ResumeLayout(false);
            tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tabPageDeliveries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPageEmployees.ResumeLayout(false);
            tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmpl).EndInit();
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
        private Button buttonCreateOrder;
        private Button buttonGoToOrder;
        private DataGridView dataGridView1;
        private Button buttonGoToDelivery;
        private Button buttonCreateDelivery;
        private DataGridViewTextBoxColumn empl_id;
        private DataGridViewTextBoxColumn position;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn middle_name;
        private DataGridViewTextBoxColumn phone_number;
    }
}
