namespace IS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.profileButton = new System.Windows.Forms.Button();
            this.requestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(167, 126);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(155, 43);
            this.profileButton.TabIndex = 1;
            this.profileButton.Text = "Профиль";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(167, 192);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(155, 65);
            this.requestButton.TabIndex = 2;
            this.requestButton.Text = "Оставить заявку на ремнот";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 483);
            this.Controls.Add(this.requestButton);
            this.Controls.Add(this.profileButton);
            this.Name = "Form1";
            this.Text = "Сервис ремонта компьютерной техники";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button requestButton;
    }
}

