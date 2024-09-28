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
            tabPageDeliveries = new TabPage();
            tabPageEmployees = new TabPage();
            textBoxSearchEmpl = new TextBox();
            buttonAddEmpl = new Button();
            buttonSearchEmpl = new Button();
            dataGridViewEmpl = new DataGridView();
            label1 = new Label();
            tabControl1.SuspendLayout();
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
            tabControl1.Size = new Size(785, 436);
            tabControl1.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            tabPageOrders.Location = new Point(4, 29);
            tabPageOrders.Name = "tabPageOrders";
            tabPageOrders.Padding = new Padding(3);
            tabPageOrders.Size = new Size(777, 403);
            tabPageOrders.TabIndex = 0;
            tabPageOrders.Text = "Заказы";
            tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // tabPageDeliveries
            // 
            tabPageDeliveries.Location = new Point(4, 29);
            tabPageDeliveries.Name = "tabPageDeliveries";
            tabPageDeliveries.Padding = new Padding(3);
            tabPageDeliveries.Size = new Size(777, 403);
            tabPageDeliveries.TabIndex = 1;
            tabPageDeliveries.Text = "Поставки";
            tabPageDeliveries.UseVisualStyleBackColor = true;
            // 
            // tabPageEmployees
            // 
            tabPageEmployees.Controls.Add(textBoxSearchEmpl);
            tabPageEmployees.Controls.Add(buttonAddEmpl);
            tabPageEmployees.Controls.Add(buttonSearchEmpl);
            tabPageEmployees.Controls.Add(dataGridViewEmpl);
            tabPageEmployees.Controls.Add(label1);
            tabPageEmployees.Location = new Point(4, 29);
            tabPageEmployees.Name = "tabPageEmployees";
            tabPageEmployees.Size = new Size(777, 403);
            tabPageEmployees.TabIndex = 2;
            tabPageEmployees.Text = "Сотрудники";
            tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchEmpl
            // 
            textBoxSearchEmpl.Location = new Point(575, 35);
            textBoxSearchEmpl.Name = "textBoxSearchEmpl";
            textBoxSearchEmpl.Size = new Size(169, 27);
            textBoxSearchEmpl.TabIndex = 4;
            // 
            // buttonAddEmpl
            // 
            buttonAddEmpl.Location = new Point(575, 341);
            buttonAddEmpl.Name = "buttonAddEmpl";
            buttonAddEmpl.Size = new Size(169, 47);
            buttonAddEmpl.TabIndex = 3;
            buttonAddEmpl.Text = "Добавить сотрудника";
            buttonAddEmpl.UseVisualStyleBackColor = true;
            buttonAddEmpl.Click += buttonAddEmpl_Click;
            // 
            // buttonSearchEmpl
            // 
            buttonSearchEmpl.Location = new Point(575, 75);
            buttonSearchEmpl.Name = "buttonSearchEmpl";
            buttonSearchEmpl.Size = new Size(169, 29);
            buttonSearchEmpl.TabIndex = 2;
            buttonSearchEmpl.Text = "Поиск";
            buttonSearchEmpl.UseVisualStyleBackColor = true;
            buttonSearchEmpl.Click += buttonSearchEmpl_Click;
            // 
            // dataGridViewEmpl
            // 
            dataGridViewEmpl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmpl.Location = new Point(3, 35);
            dataGridViewEmpl.Name = "dataGridViewEmpl";
            dataGridViewEmpl.RowHeadersWidth = 51;
            dataGridViewEmpl.Size = new Size(533, 365);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Сервис ремонта компьютерной техники";
            tabControl1.ResumeLayout(false);
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
        private Button buttonSearchEmpl;
        private DataGridView dataGridViewEmpl;
        private Label label1;
        private TextBox textBoxSearchEmpl;
    }
}
