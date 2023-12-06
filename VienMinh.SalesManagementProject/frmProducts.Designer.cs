namespace VienMinh.SalesManagementProject
{
    partial class frmProducts
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
            gbGeneralInfo = new GroupBox();
            dgvProductList = new DataGridView();
            gbDetailInfo = new GroupBox();
            mtxtUnitPrice = new MaskedTextBox();
            mtxtUnitInStock = new MaskedTextBox();
            mtxtCategoryID = new MaskedTextBox();
            mtxtProductID = new MaskedTextBox();
            txtWeight = new TextBox();
            btnDelete = new Button();
            txtProductName = new TextBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            lbUnitPrice = new Label();
            lbWeight = new Label();
            lbUnitInStock = new Label();
            lbProductName = new Label();
            lbProductID = new Label();
            lbCategoryID = new Label();
            lbTitle = new Label();
            btnSearch = new Button();
            btnBack = new Button();
            txtSearch = new TextBox();
            btnPrice = new Button();
            txt1 = new TextBox();
            txt2 = new TextBox();
            comboBox1 = new ComboBox();
            gbGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            gbDetailInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbGeneralInfo
            // 
            gbGeneralInfo.Controls.Add(dgvProductList);
            gbGeneralInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbGeneralInfo.Location = new Point(12, 81);
            gbGeneralInfo.Name = "gbGeneralInfo";
            gbGeneralInfo.Size = new Size(738, 422);
            gbGeneralInfo.TabIndex = 15;
            gbGeneralInfo.TabStop = false;
            gbGeneralInfo.Text = "General Information";
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(6, 28);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new Size(726, 388);
            dgvProductList.TabIndex = 0;
            dgvProductList.CellClick += dgvProductList_CellClick;
            // 
            // gbDetailInfo
            // 
            gbDetailInfo.Controls.Add(mtxtUnitPrice);
            gbDetailInfo.Controls.Add(mtxtUnitInStock);
            gbDetailInfo.Controls.Add(mtxtCategoryID);
            gbDetailInfo.Controls.Add(mtxtProductID);
            gbDetailInfo.Controls.Add(txtWeight);
            gbDetailInfo.Controls.Add(btnDelete);
            gbDetailInfo.Controls.Add(txtProductName);
            gbDetailInfo.Controls.Add(btnUpdate);
            gbDetailInfo.Controls.Add(btnAdd);
            gbDetailInfo.Controls.Add(lbUnitPrice);
            gbDetailInfo.Controls.Add(lbWeight);
            gbDetailInfo.Controls.Add(lbUnitInStock);
            gbDetailInfo.Controls.Add(lbProductName);
            gbDetailInfo.Controls.Add(lbProductID);
            gbDetailInfo.Controls.Add(lbCategoryID);
            gbDetailInfo.FlatStyle = FlatStyle.Popup;
            gbDetailInfo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbDetailInfo.Location = new Point(756, 50);
            gbDetailInfo.Name = "gbDetailInfo";
            gbDetailInfo.Size = new Size(300, 391);
            gbDetailInfo.TabIndex = 9;
            gbDetailInfo.TabStop = false;
            gbDetailInfo.Text = "Detail Information";
            // 
            // mtxtUnitPrice
            // 
            mtxtUnitPrice.Location = new Point(113, 234);
            mtxtUnitPrice.Mask = "000000000";
            mtxtUnitPrice.Name = "mtxtUnitPrice";
            mtxtUnitPrice.Size = new Size(174, 27);
            mtxtUnitPrice.TabIndex = 29;
            mtxtUnitPrice.ValidatingType = typeof(int);
            // 
            // mtxtUnitInStock
            // 
            mtxtUnitInStock.Location = new Point(113, 283);
            mtxtUnitInStock.Mask = "00000";
            mtxtUnitInStock.Name = "mtxtUnitInStock";
            mtxtUnitInStock.Size = new Size(174, 27);
            mtxtUnitInStock.TabIndex = 28;
            // 
            // mtxtCategoryID
            // 
            mtxtCategoryID.Location = new Point(113, 81);
            mtxtCategoryID.Mask = "00000";
            mtxtCategoryID.Name = "mtxtCategoryID";
            mtxtCategoryID.Size = new Size(174, 27);
            mtxtCategoryID.TabIndex = 27;
            mtxtCategoryID.ValidatingType = typeof(int);
            // 
            // mtxtProductID
            // 
            mtxtProductID.Location = new Point(113, 34);
            mtxtProductID.Mask = "00000";
            mtxtProductID.Name = "mtxtProductID";
            mtxtProductID.ReadOnly = true;
            mtxtProductID.Size = new Size(174, 27);
            mtxtProductID.TabIndex = 26;
            mtxtProductID.ValidatingType = typeof(int);
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(113, 185);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(174, 27);
            txtWeight.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = SystemColors.ControlDarkDark;
            btnDelete.Location = new Point(225, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 48);
            btnDelete.TabIndex = 25;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(113, 131);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(174, 27);
            txtProductName.TabIndex = 18;
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = SystemColors.ControlDarkDark;
            btnUpdate.Location = new Point(113, 337);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(67, 48);
            btnUpdate.TabIndex = 24;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(6, 337);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(67, 48);
            btnAdd.TabIndex = 23;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(6, 241);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(68, 20);
            lbUnitPrice.TabIndex = 5;
            lbUnitPrice.Text = "UnitPrice";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(6, 192);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(55, 20);
            lbWeight.TabIndex = 4;
            lbWeight.Text = "Weight";
            // 
            // lbUnitInStock
            // 
            lbUnitInStock.AutoSize = true;
            lbUnitInStock.Location = new Point(6, 290);
            lbUnitInStock.Name = "lbUnitInStock";
            lbUnitInStock.Size = new Size(90, 20);
            lbUnitInStock.TabIndex = 3;
            lbUnitInStock.Text = "Unit In Stock";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(6, 138);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(102, 20);
            lbProductName.TabIndex = 2;
            lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(6, 41);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(74, 20);
            lbProductID.TabIndex = 1;
            lbProductID.Text = "ProductID";
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(6, 88);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(86, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = SystemColors.ControlText;
            lbTitle.Location = new Point(426, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(303, 38);
            lbTitle.TabIndex = 19;
            lbTitle.Text = "Product Management";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(12, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(60, 25);
            btnSearch.TabIndex = 22;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.ForeColor = SystemColors.ControlDarkDark;
            btnBack.Location = new Point(762, 457);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(287, 46);
            btnBack.TabIndex = 26;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.Location = new Point(78, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(672, 25);
            txtSearch.TabIndex = 27;
            txtSearch.Text = "you are looking for...\r\n";
            // 
            // btnPrice
            // 
            btnPrice.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrice.Location = new Point(12, 509);
            btnPrice.Name = "btnPrice";
            btnPrice.Size = new Size(60, 25);
            btnPrice.TabIndex = 28;
            btnPrice.UseVisualStyleBackColor = true;
            btnPrice.Click += btnPrice_Click;
            // 
            // txt1
            // 
            txt1.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            txt1.Location = new Point(251, 509);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 24);
            txt1.TabIndex = 29;
            txt1.Text = "Start with...";
            txt1.KeyPress += txt1_KeyPress;
            // 
            // txt2
            // 
            txt2.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            txt2.Location = new Point(382, 509);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 24);
            txt2.TabIndex = 30;
            txt2.Text = "End with...";
            txt2.KeyPress += txt1_KeyPress;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 509);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 28);
            comboBox1.TabIndex = 31;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = SalesWinApp.Properties.Resources.OIP__1_;
            ClientSize = new Size(1068, 569);
            Controls.Add(comboBox1);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(btnPrice);
            Controls.Add(txtSearch);
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(gbDetailInfo);
            Controls.Add(lbTitle);
            Controls.Add(gbGeneralInfo);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmProducts_Load;
            KeyPress += txt1_KeyPress;
            gbGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            gbDetailInfo.ResumeLayout(false);
            gbDetailInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbGeneralInfo;
        private DataGridView dgvProductList;
        private GroupBox gbDetailInfo;
        private TextBox txtProductName;
        private Label lbUnitPrice;
        private Label lbWeight;
        private Label lbUnitInStock;
        private Label lbProductName;
        private Label lbProductID;
        private Label lbCategoryID;
        private Label lbTitle;
        private Button btnSearch;
        private TextBox txtWeight;
        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtSearch;
        //Tri
        private Button btnPrice;
        private TextBox txt1;
        private TextBox txt2;
        private ComboBox comboBox1;
        private MaskedTextBox mtxtUnitInStock;
        private MaskedTextBox mtxtCategoryID;
        private MaskedTextBox mtxtProductID;
        private MaskedTextBox mtxtUnitPrice;
        //Tri
    }
}