namespace VienMinh.SalesManagementProject
{
    partial class frmOrders
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
            lbTitle = new Label();
            gbDetailInfo = new GroupBox();
            dtpShippedDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpOrderDate = new DateTimePicker();
            cbMemberID = new ComboBox();
            txtOrderID = new TextBox();
            txtFreight = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnMoreDetail = new Button();
            btnAdd = new Button();
            lbRequiredDate = new Label();
            lbOrderDate = new Label();
            lbShippedDate = new Label();
            lbFreight = new Label();
            lbOrderID = new Label();
            lbMemberID = new Label();
            gbGeneralInfo = new GroupBox();
            dgvOrderList = new DataGridView();
            btnBack = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            gbDetailInfo.SuspendLayout();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(366, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(275, 38);
            lbTitle.TabIndex = 6;
            lbTitle.Text = "Order Management";
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.Controls.Add(dtpShippedDate);
            gbDetailInfo.Controls.Add(dtpRequiredDate);
            gbDetailInfo.Controls.Add(dtpOrderDate);
            gbDetailInfo.Controls.Add(cbMemberID);
            gbDetailInfo.Controls.Add(txtOrderID);
            gbDetailInfo.Controls.Add(txtFreight);
            gbDetailInfo.Controls.Add(btnUpdate);
            gbDetailInfo.Controls.Add(btnDelete);
            gbDetailInfo.Controls.Add(btnMoreDetail);
            gbDetailInfo.Controls.Add(btnAdd);
            gbDetailInfo.Controls.Add(lbRequiredDate);
            gbDetailInfo.Controls.Add(lbOrderDate);
            gbDetailInfo.Controls.Add(lbShippedDate);
            gbDetailInfo.Controls.Add(lbFreight);
            gbDetailInfo.Controls.Add(lbOrderID);
            gbDetailInfo.Controls.Add(lbMemberID);
            gbDetailInfo.FlatStyle = FlatStyle.Popup;
            gbDetailInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDetailInfo.Location = new Point(789, 46);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(292, 402);
            gbDetailInfo.TabIndex = 8;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Format = DateTimePickerFormat.Short;
            dtpShippedDate.Location = new Point(113, 283);
            dtpShippedDate.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dtpShippedDate.MinDate = new DateTime(1996, 1, 1, 0, 0, 0, 0);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(164, 27);
            dtpShippedDate.TabIndex = 25;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Format = DateTimePickerFormat.Short;
            dtpRequiredDate.Location = new Point(113, 234);
            dtpRequiredDate.MaxDate = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            dtpRequiredDate.MinDate = new DateTime(1996, 1, 1, 0, 0, 0, 0);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(164, 27);
            dtpRequiredDate.TabIndex = 24;
            dtpRequiredDate.Value = new DateTime(2022, 12, 31, 0, 0, 0, 0);
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(113, 185);
            dtpOrderDate.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dtpOrderDate.MinDate = new DateTime(1996, 1, 1, 0, 0, 0, 0);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(164, 27);
            dtpOrderDate.TabIndex = 23;
            dtpOrderDate.Value = new DateTime(2022, 7, 9, 0, 0, 0, 0);
            // 
            // cbMemberID
            // 
            cbMemberID.FormattingEnabled = true;
            cbMemberID.Location = new Point(113, 80);
            cbMemberID.Name = "cbMemberID";
            cbMemberID.Size = new Size(164, 28);
            cbMemberID.TabIndex = 22;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(113, 30);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.ReadOnly = true;
            txtOrderID.Size = new Size(164, 27);
            txtOrderID.TabIndex = 6;
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(113, 131);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(164, 27);
            txtFreight.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = SystemColors.ControlDarkDark;
            btnUpdate.Location = new Point(215, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(62, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ControlDarkDark;
            btnDelete.Location = new Point(113, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 42);
            btnDelete.TabIndex = 11;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMoreDetail
            // 
            btnMoreDetail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnMoreDetail.Location = new Point(172, 316);
            btnMoreDetail.Name = "btnMoreDetail";
            btnMoreDetail.Size = new Size(105, 28);
            btnMoreDetail.TabIndex = 12;
            btnMoreDetail.Text = "More Detail";
            btnMoreDetail.UseVisualStyleBackColor = true;
            btnMoreDetail.Click += btnMoreDetail_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(8, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 42);
            btnAdd.TabIndex = 10;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(6, 241);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(96, 20);
            lbRequiredDate.TabIndex = 5;
            lbRequiredDate.Text = "RequiredDate";
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(6, 192);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(80, 20);
            lbOrderDate.TabIndex = 4;
            lbOrderDate.Text = "Order Date";
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(6, 290);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(94, 20);
            lbShippedDate.TabIndex = 3;
            lbShippedDate.Text = "Shipped Date";
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(6, 138);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(53, 20);
            lbFreight.TabIndex = 2;
            lbFreight.Text = "Freight";
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(6, 41);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(64, 20);
            lbOrderID.TabIndex = 1;
            lbOrderID.Text = "Order ID";
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(6, 88);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID";
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvOrderList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(12, 50);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(770, 450);
            gbGeneralInfo.TabIndex = 14;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(0, 32);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new Size(764, 412);
            dgvOrderList.TabIndex = 0;
            dgvOrderList.CellClick += dgvOrderList_CellClick;
            dgvOrderList.CellDoubleClick += dgvOrderList_CellDoubleClick;
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ControlDarkDark;
            btnBack.Location = new Point(797, 454);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(269, 40);
            btnBack.TabIndex = 27;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(222, 576);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(508, 576);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 29;
            // 
            // button1
            // 
            button1.Location = new Point(70, 574);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 30;
            button1.Text = "Report";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = SalesWinApp.Properties.Resources.R__1_;
            ClientSize = new Size(1093, 671);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBack);
            Controls.Add(gbGeneralInfo);
            Controls.Add(gbDetailInfo);
            Controls.Add(lbTitle);
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "Add";
            Load += frmOrders_Load;
            gbDetailInfo.ResumeLayout(false);
            gbDetailInfo.PerformLayout();
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private GroupBox gbDetailInfo;
        private TextBox txtOrderID;
        private Label lbRequiredDate;
        private Label lbOrderDate;
        private Label lbShippedDate;
        private Label lbFreight;
        private Label lbOrderID;
        private Label lbMemberID;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnMoreDetail;
        private GroupBox gbGeneralInfo;
        private DataGridView dgvOrderList;
        private TextBox txtFreight;
        private Button btnBack;
        private DateTimePicker dtpShippedDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpOrderDate;
        //Tri

        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private ComboBox cbMemberID;
        //Tri
    }
}