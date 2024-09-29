namespace IS_v2
{
    partial class AddEmplForm
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
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMidName = new TextBox();
            textBoxPhoneNumber = new TextBox();
            comboBoxPosition = new ComboBox();
            buttonAddNewEmpl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(68, 44);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(183, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(68, 108);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(183, 27);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxMidName
            // 
            textBoxMidName.Location = new Point(68, 177);
            textBoxMidName.Name = "textBoxMidName";
            textBoxMidName.Size = new Size(183, 27);
            textBoxMidName.TabIndex = 2;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(68, 245);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(183, 27);
            textBoxPhoneNumber.TabIndex = 3;
            // 
            // comboBoxPosition
            // 
            comboBoxPosition.FormattingEnabled = true;
            comboBoxPosition.Location = new Point(68, 310);
            comboBoxPosition.Name = "comboBoxPosition";
            comboBoxPosition.Size = new Size(183, 28);
            comboBoxPosition.TabIndex = 4;
            // 
            // buttonAddNewEmpl
            // 
            buttonAddNewEmpl.Location = new Point(68, 384);
            buttonAddNewEmpl.Name = "buttonAddNewEmpl";
            buttonAddNewEmpl.Size = new Size(183, 43);
            buttonAddNewEmpl.TabIndex = 5;
            buttonAddNewEmpl.Text = "Добавить";
            buttonAddNewEmpl.UseVisualStyleBackColor = true;
            buttonAddNewEmpl.Click += buttonAddNewEmpl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(68, 18);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 6;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(68, 82);
            label2.Name = "label2";
            label2.Size = new Size(81, 23);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(68, 151);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 8;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(68, 219);
            label4.Name = "label4";
            label4.Size = new Size(143, 23);
            label4.TabIndex = 9;
            label4.Text = "Номер телефона";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(68, 284);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 10;
            label5.Text = "Должность";
            // 
            // AddEmplForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAddNewEmpl);
            Controls.Add(comboBoxPosition);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxMidName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Name = "AddEmplForm";
            Text = "Добавить сотрудника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxMidName;
        private TextBox textBoxPhoneNumber;
        private ComboBox comboBoxPosition;
        private Button buttonAddNewEmpl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}