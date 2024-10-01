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
            textBox1 = new TextBox();
            comboBoxComponents = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(209, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // comboBoxComponents
            // 
            comboBoxComponents.FormattingEnabled = true;
            comboBoxComponents.Location = new Point(210, 115);
            comboBoxComponents.Name = "comboBoxComponents";
            comboBoxComponents.Size = new Size(151, 28);
            comboBoxComponents.TabIndex = 1;
            // 
            // AddDeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxComponents);
            Controls.Add(textBox1);
            Name = "AddDeliveryForm";
            Text = "Добавить поставку";
            Load += AddDeliveryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBoxComponents;
    }
}