namespace VienMinh.SalesManagementProject
{
    partial class frmMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMembers));
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lbTitle = new Label();
            gbDetailInfo = new GroupBox();
            txtCountry = new TextBox();
            txtCompany = new TextBox();
            txtCity = new TextBox();
            txtPassword = new TextBox();
            txtGmail = new TextBox();
            txtMemberID = new TextBox();
            lbCity = new Label();
            lbCountry = new Label();
            lbCompany = new Label();
            lbPassword = new Label();
            lbGmail = new Label();
            lbMemberID = new Label();
            gbGeneralInfo = new GroupBox();
            dgvMemberList = new DataGridView();
            btnBack = new Button();
            gbDetailInfo.SuspendLayout();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(822, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(45, 44);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = SystemColors.ControlDarkDark;
            btnUpdate.Location = new Point(822, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(45, 44);
            btnUpdate.TabIndex = 2;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ControlDarkDark;
            btnDelete.Location = new Point(822, 127);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(45, 44);
            btnDelete.TabIndex = 3;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(363, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(311, 38);
            lbTitle.TabIndex = 5;
            lbTitle.Text = "Member Management";
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.Controls.Add(txtCountry);
            gbDetailInfo.Controls.Add(txtCompany);
            gbDetailInfo.Controls.Add(txtCity);
            gbDetailInfo.Controls.Add(btnDelete);
            gbDetailInfo.Controls.Add(txtPassword);
            gbDetailInfo.Controls.Add(txtGmail);
            gbDetailInfo.Controls.Add(txtMemberID);
            gbDetailInfo.Controls.Add(btnUpdate);
            gbDetailInfo.Controls.Add(btnAdd);
            gbDetailInfo.Controls.Add(lbCity);
            gbDetailInfo.Controls.Add(lbCountry);
            gbDetailInfo.Controls.Add(lbCompany);
            gbDetailInfo.Controls.Add(lbPassword);
            gbDetailInfo.Controls.Add(lbGmail);
            gbDetailInfo.Controls.Add(lbMemberID);
            gbDetailInfo.FlatStyle = FlatStyle.Popup;
            gbDetailInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDetailInfo.Location = new Point(12, 64);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(880, 177);
            gbDetailInfo.TabIndex = 7;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(502, 38);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(291, 27);
            txtCountry.TabIndex = 31;
            // 
            // txtCompany
            // 
            txtCompany.Location = new Point(502, 139);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new Size(291, 27);
            txtCompany.TabIndex = 13;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(502, 91);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(291, 27);
            txtCity.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(108, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(286, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(108, 89);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(286, 27);
            txtGmail.TabIndex = 7;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(108, 38);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(286, 27);
            txtMemberID.TabIndex = 6;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(424, 97);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(35, 20);
            lbCity.TabIndex = 5;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(424, 46);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 4;
            lbCountry.Text = "Country";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Location = new Point(424, 145);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(71, 20);
            lbCompany.TabIndex = 3;
            lbCompany.Text = "Company";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(14, 146);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // lbGmail
            // 
            lbGmail.AutoSize = true;
            lbGmail.Location = new Point(14, 96);
            lbGmail.Name = "lbGmail";
            lbGmail.Size = new Size(48, 20);
            lbGmail.TabIndex = 1;
            lbGmail.Text = "Gmail";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(14, 46);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvMemberList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(12, 247);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(940, 281);
            gbGeneralInfo.TabIndex = 8;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(0, 32);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new Size(934, 249);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellClick += dgvMemberList_CellClick;
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ControlDarkDark;
            btnBack.Location = new Point(898, 119);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(54, 94);
            btnBack.TabIndex = 27;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(958, 538);
            Controls.Add(btnBack);
            Controls.Add(gbGeneralInfo);
            Controls.Add(gbDetailInfo);
            Controls.Add(lbTitle);
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMembers_Load;
            gbDetailInfo.ResumeLayout(false);
            gbDetailInfo.PerformLayout();
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label lbTitle;
        private GroupBox gbDetailInfo;
        private GroupBox gbGeneralInfo;
        private TextBox txtPassword;
        private Label lbCity;
        private Label lbCountry;
        private Label lbCompany;
        private Label lbPassword;
        private Label lbGmail;
        private Label lbMemberID;
        private TextBox txtCompany;
        private TextBox txtCity;
        private DataGridView dgvMemberList;
        private Button btnBack;
        private TextBox txtCountry;
        private TextBox txtGmail;
        private TextBox txtMemberID;
    }
}