namespace VienMinh.SalesManagementProject
{
    partial class frmLogin
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
            pbLogin = new PictureBox();
            lbTitle = new Label();
            btnLogin = new Button();
            lbGmail = new Label();
            txtGmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogin).BeginInit();
            SuspendLayout();
            // 
            // pbLogin
            // 
            pbLogin.Image = SalesWinApp.Properties.Resources.OIP__2_;
            pbLogin.Location = new Point(1, 1);
            pbLogin.Name = "pbLogin";
            pbLogin.Size = new Size(629, 323);
            pbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogin.TabIndex = 0;
            pbLogin.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = SystemColors.Control;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(110, 1);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(425, 38);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Sales Management Application";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(183, 396);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 33);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Location = new Point(107, 337);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(48, 20);
            lbGmail.TabIndex = 8;
            lbGmail.Text = "Gmail";
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(183, 330);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(352, 27);
            txtGmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 370);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 10;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(183, 363);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(352, 27);
            txtPassword.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(441, 396);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 33);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 441);
            Controls.Add(btnClose);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtGmail);
            Controls.Add(lbGmail);
            Controls.Add(btnLogin);
            Controls.Add(lbTitle);
            Controls.Add(pbLogin);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pbLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogin;
        private Label lbTitle;
        private Button btnLogin;
        private Label lbGmail;
        private TextBox txtGmail;
        private Label label1;
        private TextBox txtPassword;
        private Button btnClose;
    }
}