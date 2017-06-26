namespace Client
{
    partial class EntryForm
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
            this.panelReg = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxRPassword = new System.Windows.Forms.TextBox();
            this.textBoxRLogin = new System.Windows.Forms.TextBox();
            this.textBoxRName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEnter = new System.Windows.Forms.Panel();
            this.buttonCanselE = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxEPassword = new System.Windows.Forms.TextBox();
            this.textBoxELogin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonPanelReg = new System.Windows.Forms.Button();
            this.buttonPanelEnter = new System.Windows.Forms.Button();
            this.panelReg.SuspendLayout();
            this.panelEnter.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReg
            // 
            this.panelReg.BackColor = System.Drawing.Color.Beige;
            this.panelReg.Controls.Add(this.buttonCancel);
            this.panelReg.Controls.Add(this.buttonReg);
            this.panelReg.Controls.Add(this.textBoxRPassword);
            this.panelReg.Controls.Add(this.textBoxRLogin);
            this.panelReg.Controls.Add(this.textBoxRName);
            this.panelReg.Controls.Add(this.label3);
            this.panelReg.Controls.Add(this.label2);
            this.panelReg.Controls.Add(this.label1);
            this.panelReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReg.Location = new System.Drawing.Point(0, 0);
            this.panelReg.Name = "panelReg";
            this.panelReg.Size = new System.Drawing.Size(330, 250);
            this.panelReg.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCancel.Location = new System.Drawing.Point(186, 198);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 27);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReg.Location = new System.Drawing.Point(32, 198);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(148, 27);
            this.buttonReg.TabIndex = 6;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxRPassword
            // 
            this.textBoxRPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRPassword.Location = new System.Drawing.Point(32, 152);
            this.textBoxRPassword.Name = "textBoxRPassword";
            this.textBoxRPassword.Size = new System.Drawing.Size(272, 20);
            this.textBoxRPassword.TabIndex = 5;
            // 
            // textBoxRLogin
            // 
            this.textBoxRLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRLogin.Location = new System.Drawing.Point(32, 95);
            this.textBoxRLogin.Name = "textBoxRLogin";
            this.textBoxRLogin.Size = new System.Drawing.Size(272, 20);
            this.textBoxRLogin.TabIndex = 4;
            // 
            // textBoxRName
            // 
            this.textBoxRName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRName.Location = new System.Drawing.Point(32, 42);
            this.textBoxRName.Name = "textBoxRName";
            this.textBoxRName.Size = new System.Drawing.Size(272, 20);
            this.textBoxRName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Придумайте пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Придумайте логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ваше имя";
            // 
            // panelEnter
            // 
            this.panelEnter.BackColor = System.Drawing.Color.Beige;
            this.panelEnter.Controls.Add(this.buttonCanselE);
            this.panelEnter.Controls.Add(this.buttonEnter);
            this.panelEnter.Controls.Add(this.textBoxEPassword);
            this.panelEnter.Controls.Add(this.textBoxELogin);
            this.panelEnter.Controls.Add(this.label5);
            this.panelEnter.Controls.Add(this.label4);
            this.panelEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEnter.Location = new System.Drawing.Point(0, 0);
            this.panelEnter.Name = "panelEnter";
            this.panelEnter.Size = new System.Drawing.Size(330, 250);
            this.panelEnter.TabIndex = 7;
            // 
            // buttonCanselE
            // 
            this.buttonCanselE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCanselE.Location = new System.Drawing.Point(177, 188);
            this.buttonCanselE.Name = "buttonCanselE";
            this.buttonCanselE.Size = new System.Drawing.Size(85, 27);
            this.buttonCanselE.TabIndex = 5;
            this.buttonCanselE.Text = "Отмена";
            this.buttonCanselE.UseVisualStyleBackColor = true;
            this.buttonCanselE.Click += new System.EventHandler(this.buttonCanselE_Click);
            // 
            // buttonEnter
            // 
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnter.Location = new System.Drawing.Point(77, 188);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(85, 27);
            this.buttonEnter.TabIndex = 4;
            this.buttonEnter.Text = "Вход";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxEPassword
            // 
            this.textBoxEPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEPassword.Location = new System.Drawing.Point(46, 136);
            this.textBoxEPassword.Name = "textBoxEPassword";
            this.textBoxEPassword.Size = new System.Drawing.Size(243, 20);
            this.textBoxEPassword.TabIndex = 3;
            // 
            // textBoxELogin
            // 
            this.textBoxELogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxELogin.Location = new System.Drawing.Point(46, 68);
            this.textBoxELogin.Name = "textBoxELogin";
            this.textBoxELogin.Size = new System.Drawing.Size(243, 20);
            this.textBoxELogin.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Введите пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите логин";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MintCream;
            this.panelMain.Controls.Add(this.buttonPanelReg);
            this.panelMain.Controls.Add(this.buttonPanelEnter);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(330, 250);
            this.panelMain.TabIndex = 5;
            // 
            // buttonPanelReg
            // 
            this.buttonPanelReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPanelReg.Location = new System.Drawing.Point(167, 95);
            this.buttonPanelReg.Name = "buttonPanelReg";
            this.buttonPanelReg.Size = new System.Drawing.Size(105, 27);
            this.buttonPanelReg.TabIndex = 1;
            this.buttonPanelReg.Text = "Регистрация";
            this.buttonPanelReg.UseVisualStyleBackColor = true;
            this.buttonPanelReg.Click += new System.EventHandler(this.buttonPanelReg_Click);
            // 
            // buttonPanelEnter
            // 
            this.buttonPanelEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPanelEnter.Location = new System.Drawing.Point(62, 95);
            this.buttonPanelEnter.Name = "buttonPanelEnter";
            this.buttonPanelEnter.Size = new System.Drawing.Size(75, 27);
            this.buttonPanelEnter.TabIndex = 0;
            this.buttonPanelEnter.Text = "Войти";
            this.buttonPanelEnter.UseVisualStyleBackColor = true;
            this.buttonPanelEnter.Click += new System.EventHandler(this.buttonPanelEnter_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 250);
            this.Controls.Add(this.panelReg);
            this.Controls.Add(this.panelEnter);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EntryForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panelReg.ResumeLayout(false);
            this.panelReg.PerformLayout();
            this.panelEnter.ResumeLayout(false);
            this.panelEnter.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReg;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxRPassword;
        private System.Windows.Forms.TextBox textBoxRLogin;
        private System.Windows.Forms.TextBox textBoxRName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelEnter;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxEPassword;
        private System.Windows.Forms.TextBox textBoxELogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonPanelReg;
        private System.Windows.Forms.Button buttonPanelEnter;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCanselE;
    }
}