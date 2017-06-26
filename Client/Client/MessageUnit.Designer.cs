namespace Client
{
    partial class MessageUnit
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitle.Location = new System.Drawing.Point(5, 5);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(188, 21);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "Заголовок сообщения";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDate
            // 
            this.labelDate.BackColor = System.Drawing.Color.MintCream;
            this.labelDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDate.Location = new System.Drawing.Point(5, 26);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(188, 21);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "00.00.0000 00:00:00";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelText.Location = new System.Drawing.Point(5, 47);
            this.labelText.MaximumSize = new System.Drawing.Size(170, 0);
            this.labelText.Name = "labelText";
            this.labelText.Padding = new System.Windows.Forms.Padding(5);
            this.labelText.Size = new System.Drawing.Size(107, 23);
            this.labelText.TabIndex = 14;
            this.labelText.Text = "Текст сообщения";
            // 
            // MessageUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Beige;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTitle);
            this.MinimumSize = new System.Drawing.Size(200, 100);
            this.Name = "MessageUnit";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(198, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelText;
    }
}
