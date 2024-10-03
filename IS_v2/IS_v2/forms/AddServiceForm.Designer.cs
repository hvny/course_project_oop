namespace IS_v2.forms
{
    partial class AddServiceForm
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
            buttonAddNewService = new Button();
            textBoxServiceName = new TextBox();
            textBoxServiceDescription = new TextBox();
            textBoxServicePrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonAddNewService
            // 
            buttonAddNewService.Location = new Point(200, 147);
            buttonAddNewService.Name = "buttonAddNewService";
            buttonAddNewService.Size = new Size(125, 41);
            buttonAddNewService.TabIndex = 0;
            buttonAddNewService.Text = "Добавить";
            buttonAddNewService.UseVisualStyleBackColor = true;
            buttonAddNewService.Click += buttonAddNewService_Click;
            // 
            // textBoxServiceName
            // 
            textBoxServiceName.Location = new Point(12, 38);
            textBoxServiceName.Name = "textBoxServiceName";
            textBoxServiceName.Size = new Size(172, 27);
            textBoxServiceName.TabIndex = 1;
            // 
            // textBoxServiceDescription
            // 
            textBoxServiceDescription.Location = new Point(12, 100);
            textBoxServiceDescription.Multiline = true;
            textBoxServiceDescription.Name = "textBoxServiceDescription";
            textBoxServiceDescription.Size = new Size(172, 88);
            textBoxServiceDescription.TabIndex = 2;
            // 
            // textBoxServicePrice
            // 
            textBoxServicePrice.Location = new Point(200, 38);
            textBoxServicePrice.Name = "textBoxServicePrice";
            textBoxServicePrice.Size = new Size(125, 27);
            textBoxServicePrice.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 4;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 15);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 5;
            label2.Text = "Цена";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 77);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Описание";
            // 
            // AddServiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 207);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxServicePrice);
            Controls.Add(textBoxServiceDescription);
            Controls.Add(textBoxServiceName);
            Controls.Add(buttonAddNewService);
            Name = "AddServiceForm";
            Text = "Добавить услугу";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddNewService;
        private TextBox textBoxServiceName;
        private TextBox textBoxServiceDescription;
        private TextBox textBoxServicePrice;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}