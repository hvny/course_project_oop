namespace IS_v2.forms
{
    partial class AddDeliveryForm
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
            comboBoxComponents = new ComboBox();
            dateTimePickerExpectedDate = new DateTimePicker();
            label1 = new Label();
            numericUpDownQuantity = new NumericUpDown();
            groupBox1 = new GroupBox();
            buttonAddComponentToDelivery = new Button();
            dataGridViewDeliveryComponents = new DataGridView();
            label2 = new Label();
            buttonAddDelivery = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeliveryComponents).BeginInit();
            SuspendLayout();
            // 
            // comboBoxComponents
            // 
            comboBoxComponents.FormattingEnabled = true;
            comboBoxComponents.Location = new Point(6, 32);
            comboBoxComponents.Name = "comboBoxComponents";
            comboBoxComponents.Size = new Size(142, 28);
            comboBoxComponents.TabIndex = 1;
            // 
            // dateTimePickerExpectedDate
            // 
            dateTimePickerExpectedDate.CustomFormat = "yyyy-MM-dd";
            dateTimePickerExpectedDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerExpectedDate.Location = new Point(12, 36);
            dateTimePickerExpectedDate.Name = "dateTimePickerExpectedDate";
            dateTimePickerExpectedDate.Size = new Size(178, 27);
            dateTimePickerExpectedDate.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 3;
            label1.Text = "Ожидаемая дата поставки";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(154, 32);
            numericUpDownQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(84, 27);
            numericUpDownQuantity.TabIndex = 5;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAddComponentToDelivery);
            groupBox1.Controls.Add(comboBoxComponents);
            groupBox1.Controls.Add(numericUpDownQuantity);
            groupBox1.Location = new Point(12, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 139);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор деталей";
            // 
            // buttonAddComponentToDelivery
            // 
            buttonAddComponentToDelivery.Location = new Point(78, 104);
            buttonAddComponentToDelivery.Name = "buttonAddComponentToDelivery";
            buttonAddComponentToDelivery.Size = new Size(100, 29);
            buttonAddComponentToDelivery.TabIndex = 6;
            buttonAddComponentToDelivery.Text = "Добавить";
            buttonAddComponentToDelivery.UseVisualStyleBackColor = true;
            buttonAddComponentToDelivery.Click += buttonAddComponentToDelivery_Click;
            // 
            // dataGridViewDeliveryComponents
            // 
            dataGridViewDeliveryComponents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDeliveryComponents.Location = new Point(362, 35);
            dataGridViewDeliveryComponents.Name = "dataGridViewDeliveryComponents";
            dataGridViewDeliveryComponents.RowHeadersWidth = 51;
            dataGridViewDeliveryComponents.Size = new Size(325, 188);
            dataGridViewDeliveryComponents.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 13);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 8;
            label2.Text = "Детали в поставке";
            // 
            // buttonAddDelivery
            // 
            buttonAddDelivery.Location = new Point(435, 246);
            buttonAddDelivery.Name = "buttonAddDelivery";
            buttonAddDelivery.Size = new Size(178, 52);
            buttonAddDelivery.TabIndex = 9;
            buttonAddDelivery.Text = "Добавить поставку";
            buttonAddDelivery.UseVisualStyleBackColor = true;
            buttonAddDelivery.Click += buttonAddDelivery_Click;
            // 
            // AddDeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 318);
            Controls.Add(buttonAddDelivery);
            Controls.Add(label2);
            Controls.Add(dataGridViewDeliveryComponents);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dateTimePickerExpectedDate);
            Name = "AddDeliveryForm";
            Text = "Добавить поставку";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDeliveryComponents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBoxComponents;
        private DateTimePicker dateTimePickerExpectedDate;
        private Label label1;
        private NumericUpDown numericUpDownQuantity;
        private GroupBox groupBox1;
        private Button buttonAddComponentToDelivery;
        private DataGridView dataGridViewDeliveryComponents;
        private Label label2;
        private Button buttonAddDelivery;
    }
}