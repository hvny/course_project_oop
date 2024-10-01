namespace IS_v2.forms
{
    partial class CheckDeliveryForm
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
            textBoxDeliveryId = new TextBox();
            textBoxDeliveryDate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewDeliveryComponents = new DataGridView();
            component_id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price_for_one = new DataGridViewTextBoxColumn();
            buttonEditDelivery = new Button();
            comboBoxDeliveryStatus = new ComboBox();
            textBoxDeliveryTotalPrice = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeliveryComponents).BeginInit();
            SuspendLayout();
            // 
            // textBoxDeliveryId
            // 
            textBoxDeliveryId.Location = new Point(12, 38);
            textBoxDeliveryId.Name = "textBoxDeliveryId";
            textBoxDeliveryId.ReadOnly = true;
            textBoxDeliveryId.Size = new Size(142, 27);
            textBoxDeliveryId.TabIndex = 0;
            // 
            // textBoxDeliveryDate
            // 
            textBoxDeliveryDate.Location = new Point(12, 103);
            textBoxDeliveryDate.Name = "textBoxDeliveryDate";
            textBoxDeliveryDate.Size = new Size(142, 27);
            textBoxDeliveryDate.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 3;
            label1.Text = "ID доставки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 4;
            label2.Text = "Дата прибытия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Статус";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(198, 15);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 6;
            label4.Text = "Детали";
            // 
            // dataGridViewDeliveryComponents
            // 
            dataGridViewDeliveryComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeliveryComponents.Columns.AddRange(new DataGridViewColumn[] { component_id, name, quantity, price_for_one });
            dataGridViewDeliveryComponents.Location = new Point(198, 38);
            dataGridViewDeliveryComponents.Name = "dataGridViewDeliveryComponents";
            dataGridViewDeliveryComponents.RowHeadersWidth = 51;
            dataGridViewDeliveryComponents.Size = new Size(342, 156);
            dataGridViewDeliveryComponents.TabIndex = 7;
            // 
            // component_id
            // 
            component_id.HeaderText = "id";
            component_id.MinimumWidth = 6;
            component_id.Name = "component_id";
            component_id.Width = 30;
            // 
            // name
            // 
            name.HeaderText = "Название";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // quantity
            // 
            quantity.HeaderText = "Кол-во";
            quantity.MinimumWidth = 6;
            quantity.Name = "quantity";
            quantity.Width = 60;
            // 
            // price_for_one
            // 
            price_for_one.HeaderText = "Цена за шт.";
            price_for_one.MinimumWidth = 6;
            price_for_one.Name = "price_for_one";
            price_for_one.Width = 75;
            // 
            // buttonEditDelivery
            // 
            buttonEditDelivery.Location = new Point(296, 213);
            buttonEditDelivery.Name = "buttonEditDelivery";
            buttonEditDelivery.Size = new Size(145, 39);
            buttonEditDelivery.TabIndex = 8;
            buttonEditDelivery.Text = "Редактировать";
            buttonEditDelivery.UseVisualStyleBackColor = true;
            buttonEditDelivery.Click += buttonEditDelivery_Click;
            // 
            // comboBoxDeliveryStatus
            // 
            comboBoxDeliveryStatus.FormattingEnabled = true;
            comboBoxDeliveryStatus.Items.AddRange(new object[] { "Заказана", "В пути", "Доставлена", "Отменена" });
            comboBoxDeliveryStatus.Location = new Point(12, 167);
            comboBoxDeliveryStatus.Name = "comboBoxDeliveryStatus";
            comboBoxDeliveryStatus.Size = new Size(142, 28);
            comboBoxDeliveryStatus.TabIndex = 9;
            // 
            // textBoxDeliveryTotalPrice
            // 
            textBoxDeliveryTotalPrice.Location = new Point(12, 229);
            textBoxDeliveryTotalPrice.Name = "textBoxDeliveryTotalPrice";
            textBoxDeliveryTotalPrice.ReadOnly = true;
            textBoxDeliveryTotalPrice.Size = new Size(142, 27);
            textBoxDeliveryTotalPrice.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 206);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 11;
            label5.Text = "Общая стоимость";
            // 
            // CheckDeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 273);
            Controls.Add(label5);
            Controls.Add(textBoxDeliveryTotalPrice);
            Controls.Add(comboBoxDeliveryStatus);
            Controls.Add(buttonEditDelivery);
            Controls.Add(dataGridViewDeliveryComponents);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDeliveryDate);
            Controls.Add(textBoxDeliveryId);
            Name = "CheckDeliveryForm";
            Text = "Информация о поставке";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeliveryComponents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDeliveryId;
        private TextBox textBoxDeliveryDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewDeliveryComponents;
        private Button buttonEditDelivery;
        private ComboBox comboBoxDeliveryStatus;
        private DataGridViewTextBoxColumn component_id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price_for_one;
        private TextBox textBoxDeliveryTotalPrice;
        private Label label5;
    }
}