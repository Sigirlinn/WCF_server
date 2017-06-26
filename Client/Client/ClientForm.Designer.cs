namespace Client
{
    partial class ClientForm
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
            this.listBoxUser = new System.Windows.Forms.ListBox();
            this.buttonShowUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxSMS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelNameSender = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNameRecipient = new System.Windows.Forms.Label();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxUser
            // 
            this.listBoxUser.FormattingEnabled = true;
            this.listBoxUser.Location = new System.Drawing.Point(11, 69);
            this.listBoxUser.Name = "listBoxUser";
            this.listBoxUser.ScrollAlwaysVisible = true;
            this.listBoxUser.Size = new System.Drawing.Size(154, 264);
            this.listBoxUser.TabIndex = 0;
            this.listBoxUser.SelectedIndexChanged += new System.EventHandler(this.listBoxUser_SelectedIndexChanged);
            // 
            // buttonShowUser
            // 
            this.buttonShowUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowUser.Location = new System.Drawing.Point(15, 339);
            this.buttonShowUser.Name = "buttonShowUser";
            this.buttonShowUser.Size = new System.Drawing.Size(75, 23);
            this.buttonShowUser.TabIndex = 1;
            this.buttonShowUser.Text = "Обновить";
            this.buttonShowUser.UseVisualStyleBackColor = true;
            this.buttonShowUser.Click += new System.EventHandler(this.buttonShowUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Коллеги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заголовок";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitle.Location = new System.Drawing.Point(184, 273);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(403, 20);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxSMS
            // 
            this.textBoxSMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSMS.Location = new System.Drawing.Point(184, 312);
            this.textBoxSMS.Multiline = true;
            this.textBoxSMS.Name = "textBoxSMS";
            this.textBoxSMS.Size = new System.Drawing.Size(403, 97);
            this.textBoxSMS.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сообщение";
            // 
            // buttonSend
            // 
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSend.Location = new System.Drawing.Point(184, 415);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 7;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // labelNameSender
            // 
            this.labelNameSender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNameSender.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelNameSender.Location = new System.Drawing.Point(184, 228);
            this.labelNameSender.Name = "labelNameSender";
            this.labelNameSender.Size = new System.Drawing.Size(403, 13);
            this.labelNameSender.TabIndex = 11;
            this.labelNameSender.Text = "--";
            this.labelNameSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "История переписки";
            // 
            // labelNameRecipient
            // 
            this.labelNameRecipient.AutoSize = true;
            this.labelNameRecipient.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelNameRecipient.Location = new System.Drawing.Point(184, 66);
            this.labelNameRecipient.Name = "labelNameRecipient";
            this.labelNameRecipient.Size = new System.Drawing.Size(13, 13);
            this.labelNameRecipient.TabIndex = 10;
            this.labelNameRecipient.Text = "--";
            this.labelNameRecipient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelHistory
            // 
            this.panelHistory.AutoScroll = true;
            this.panelHistory.BackColor = System.Drawing.SystemColors.Window;
            this.panelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistory.Location = new System.Drawing.Point(184, 82);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Padding = new System.Windows.Forms.Padding(10);
            this.panelHistory.Size = new System.Drawing.Size(403, 143);
            this.panelHistory.TabIndex = 13;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(8, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(86, 13);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "Пользователь: ";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 27);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Имя: ";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(595, 469);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelNameSender);
            this.Controls.Add(this.labelNameRecipient);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxSMS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShowUser);
            this.Controls.Add(this.listBoxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUser;
        private System.Windows.Forms.Button buttonShowUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxSMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelNameSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNameRecipient;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelName;
    }
}