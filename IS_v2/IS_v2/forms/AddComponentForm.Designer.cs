namespace IS_v2.forms
{
    partial class AddComponentForm
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
            textBoxComponentName = new TextBox();
            textBoxPriceForOne = new TextBox();
            numericUpDownQuantity = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAddNewComponent = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // textBoxComponentName
            // 
            textBoxComponentName.Location = new Point(12, 36);
            textBoxComponentName.Name = "textBoxComponentName";
            textBoxComponentName.Size = new Size(145, 27);
            textBoxComponentName.TabIndex = 0;
            // 
            // textBoxPriceForOne
            // 
            textBoxPriceForOne.Location = new Point(12, 90);
            textBoxPriceForOne.Name = "textBoxPriceForOne";
            textBoxPriceForOne.Size = new Size(145, 27);
            textBoxPriceForOne.TabIndex = 1;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(175, 36);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(72, 27);
            numericUpDownQuantity.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Стоимость";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 13);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 5;
            label3.Text = "Кол-во на складе";
            // 
            // buttonAddNewComponent
            // 
            buttonAddNewComponent.Location = new Point(175, 90);
            buttonAddNewComponent.Name = "buttonAddNewComponent";
            buttonAddNewComponent.Size = new Size(129, 29);
            buttonAddNewComponent.TabIndex = 6;
            buttonAddNewComponent.Text = "Добавить";
            buttonAddNewComponent.UseVisualStyleBackColor = true;
            buttonAddNewComponent.Click += this.buttonAddNewComponent_Click;
            // 
            // AddComponentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 139);
            Controls.Add(buttonAddNewComponent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(textBoxPriceForOne);
            Controls.Add(textBoxComponentName);
            Name = "AddComponentForm";
            Text = "Добавить деталь";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxComponentName;
        private TextBox textBoxPriceForOne;
        private NumericUpDown numericUpDownQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAddNewComponent;
    }
}