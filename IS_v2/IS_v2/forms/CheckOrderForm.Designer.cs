namespace IS_v2
{
    partial class CheckOrderForm
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
            textBoxId = new TextBox();
            textBoxCreatedAt = new TextBox();
            textBoxTotalPrice = new TextBox();
            textBoxDescription = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxPaymentMethod = new ComboBox();
            textBoxUserPhoneNum = new TextBox();
            textBoxUserName = new TextBox();
            groupBox2 = new GroupBox();
            comboBoxStatus = new ComboBox();
            textBoxDeviceName = new TextBox();
            buttonEditOrder = new Button();
            dataGridViewComponents = new DataGridView();
            component_id = new DataGridViewTextBoxColumn();
            component_name = new DataGridViewTextBoxColumn();
            component_quantity = new DataGridViewTextBoxColumn();
            dataGridViewServices = new DataGridView();
            service_id = new DataGridViewTextBoxColumn();
            service_name = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            labelFinishedAt = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComponents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).BeginInit();
            SuspendLayout();
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(6, 26);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(63, 27);
            textBoxId.TabIndex = 0;
            // 
            // textBoxCreatedAt
            // 
            textBoxCreatedAt.Location = new Point(6, 92);
            textBoxCreatedAt.Name = "textBoxCreatedAt";
            textBoxCreatedAt.ReadOnly = true;
            textBoxCreatedAt.Size = new Size(139, 27);
            textBoxCreatedAt.TabIndex = 1;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(6, 59);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.ReadOnly = true;
            textBoxTotalPrice.Size = new Size(139, 27);
            textBoxTotalPrice.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(165, 26);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(179, 159);
            textBoxDescription.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxPaymentMethod);
            groupBox1.Controls.Add(textBoxUserPhoneNum);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Location = new Point(380, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Данные пользователя";
            // 
            // comboBoxPaymentMethod
            // 
            comboBoxPaymentMethod.FormattingEnabled = true;
            comboBoxPaymentMethod.Location = new Point(137, 26);
            comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            comboBoxPaymentMethod.Size = new Size(114, 28);
            comboBoxPaymentMethod.TabIndex = 2;
            // 
            // textBoxUserPhoneNum
            // 
            textBoxUserPhoneNum.Location = new Point(6, 77);
            textBoxUserPhoneNum.Name = "textBoxUserPhoneNum";
            textBoxUserPhoneNum.Size = new Size(125, 27);
            textBoxUserPhoneNum.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(6, 26);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(125, 27);
            textBoxUserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxStatus);
            groupBox2.Controls.Add(textBoxDeviceName);
            groupBox2.Controls.Add(textBoxId);
            groupBox2.Controls.Add(textBoxTotalPrice);
            groupBox2.Controls.Add(textBoxDescription);
            groupBox2.Controls.Add(textBoxCreatedAt);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 200);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Заказ";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(6, 125);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(139, 28);
            comboBoxStatus.TabIndex = 6;
            // 
            // textBoxDeviceName
            // 
            textBoxDeviceName.Location = new Point(6, 159);
            textBoxDeviceName.Name = "textBoxDeviceName";
            textBoxDeviceName.Size = new Size(139, 27);
            textBoxDeviceName.TabIndex = 4;
            // 
            // buttonEditOrder
            // 
            buttonEditOrder.Location = new Point(521, 448);
            buttonEditOrder.Name = "buttonEditOrder";
            buttonEditOrder.Size = new Size(116, 45);
            buttonEditOrder.TabIndex = 6;
            buttonEditOrder.Text = "Изменить";
            buttonEditOrder.UseVisualStyleBackColor = true;
            buttonEditOrder.Click += buttonEditOrder_Click;
            // 
            // dataGridViewComponents
            // 
            dataGridViewComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComponents.Columns.AddRange(new DataGridViewColumn[] { component_id, component_name, component_quantity });
            dataGridViewComponents.Location = new Point(18, 245);
            dataGridViewComponents.Name = "dataGridViewComponents";
            dataGridViewComponents.RowHeadersWidth = 51;
            dataGridViewComponents.Size = new Size(307, 188);
            dataGridViewComponents.TabIndex = 7;
            // 
            // component_id
            // 
            component_id.HeaderText = "id";
            component_id.MinimumWidth = 6;
            component_id.Name = "component_id";
            component_id.Width = 40;
            // 
            // component_name
            // 
            component_name.HeaderText = "Наименование";
            component_name.MinimumWidth = 6;
            component_name.Name = "component_name";
            component_name.Width = 125;
            // 
            // component_quantity
            // 
            component_quantity.HeaderText = "Кол-во";
            component_quantity.MinimumWidth = 6;
            component_quantity.Name = "component_quantity";
            component_quantity.Width = 125;
            // 
            // dataGridViewServices
            // 
            dataGridViewServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewServices.Columns.AddRange(new DataGridViewColumn[] { service_id, service_name });
            dataGridViewServices.Location = new Point(337, 245);
            dataGridViewServices.Name = "dataGridViewServices";
            dataGridViewServices.RowHeadersWidth = 51;
            dataGridViewServices.Size = new Size(300, 188);
            dataGridViewServices.TabIndex = 8;
            // 
            // service_id
            // 
            service_id.HeaderText = "id";
            service_id.MinimumWidth = 6;
            service_id.Name = "service_id";
            service_id.Width = 40;
            // 
            // service_name
            // 
            service_name.HeaderText = "Наименование";
            service_name.MinimumWidth = 6;
            service_name.Name = "service_name";
            service_name.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(337, 217);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 9;
            label1.Text = "Услуги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(18, 217);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 10;
            label2.Text = "Детали";
            // 
            // labelFinishedAt
            // 
            labelFinishedAt.AutoSize = true;
            labelFinishedAt.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelFinishedAt.Location = new Point(18, 468);
            labelFinishedAt.Name = "labelFinishedAt";
            labelFinishedAt.Size = new Size(0, 25);
            labelFinishedAt.TabIndex = 11;
            // 
            // CheckOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 505);
            Controls.Add(labelFinishedAt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewServices);
            Controls.Add(dataGridViewComponents);
            Controls.Add(buttonEditOrder);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CheckOrderForm";
            Text = "Информация о заказе";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComponents).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewServices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxId;
        private TextBox textBoxCreatedAt;
        private TextBox textBoxTotalPrice;
        private TextBox textBoxDescription;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBoxDeviceName;
        private ComboBox comboBoxPaymentMethod;
        private TextBox textBoxUserPhoneNum;
        private TextBox textBoxUserName;
        private ComboBox comboBoxStatus;
        private Button buttonEditOrder;
        private DataGridView dataGridViewComponents;
        private DataGridView dataGridViewServices;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn component_id;
        private DataGridViewTextBoxColumn component_name;
        private DataGridViewTextBoxColumn component_quantity;
        private DataGridViewTextBoxColumn service_id;
        private DataGridViewTextBoxColumn service_name;
        private Label labelFinishedAt;
    }
}