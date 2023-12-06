using BusinessObject;
using DataAccess.Repository;

namespace VienMinh.SalesManagementProject
{
    public partial class frmProducts : Form
    {
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;

        public frmProducts()
        {
            InitializeComponent();
            List<String> options = new List<String>()
            {
                "Price", "Quantity"
            };
            comboBox1.DataSource = options;
            comboBox1.SelectedIndex = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            String name = txtSearch.Text;
            dgvProductList.DataSource = productRepository.Search(x => x.ProductName.Contains(name)).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = GetProductObject();
            try
            {
                if (product != null)
                {
                    productRepository.InsertProduct(product);
                    LoadProductList();
                    MessageBox.Show("Add new product successfully");
                }
                else
                {
                    throw new Exception("Add new product fail. Fill in the blank information box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var product = GetProductObject();
            try
            {
                if (product != null)
                {
                    product.ProductId = int.Parse(mtxtProductID.Text);
                    productRepository.UpdateProduct(product);
                    LoadProductList();
                    MessageBox.Show("Update product successfully");
                }
                else
                {
                    throw new Exception("Update product fail. Select a product beside to update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var productID = int.Parse(mtxtProductID.Text);
                productRepository.DeleteProduct(productID);
                LoadProductList();
                mtxtProductID.Clear();
                MessageBox.Show("Delete product successfully");
            }
            catch (Exception ex)
            {
                throw new Exception("Delete product fail. Select a product beside to delete!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvProductList.Rows.Count - 1)
            {
                mtxtProductID.Text = dgvProductList.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                mtxtCategoryID.Text = dgvProductList.Rows[e.RowIndex].Cells["CategoryID"].Value.ToString();
                txtProductName.Text = dgvProductList.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                txtWeight.Text = dgvProductList.Rows[e.RowIndex].Cells["Weight"].Value.ToString();
                mtxtUnitPrice.Text = dgvProductList.Rows[e.RowIndex].Cells["UnitPrice"].Value.ToString();
                mtxtUnitInStock.Text = dgvProductList.Rows[e.RowIndex].Cells["UnitInStock"].Value.ToString();
            }
        }

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                product = new Product
                {
                    CategoryId = int.Parse(mtxtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(mtxtUnitPrice.Text),
                    UnitInStock = int.Parse(mtxtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        private void LoadProductList()
        {
            var products = productRepository.GetProducts();
            try
            {
                source = new BindingSource();
                source.DataSource = products;

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

                dgvProductList.Columns[0].Width = (int)(dgvProductList.Width * 0.1);
                dgvProductList.Columns[1].Width = (int)(dgvProductList.Width * 0.1);
                dgvProductList.Columns[2].Width = (int)(dgvProductList.Width * 0.21);
                dgvProductList.Columns[3].Width = (int)(dgvProductList.Width * 0.2);
                dgvProductList.Columns[4].Width = (int)(dgvProductList.Width * 0.2);
                dgvProductList.Columns[5].Width = (int)(dgvProductList.Width * 0.12);
                dgvProductList.Columns[6].Width = (int)(dgvProductList.Width * 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                int num1 = int.Parse(txt1.Text);
                int num2 = int.Parse(txt2.Text);
                dgvProductList.DataSource = productRepository.Search(x => x.UnitPrice >= num1 && x.UnitPrice <= num2).ToList();

            }
            else
            {
                int num1 = int.Parse(txt1.Text);
                int num2 = int.Parse(txt2.Text);
                dgvProductList.DataSource = productRepository.Search(x => x.UnitInStock >= num1 && x.UnitInStock <= num2).ToList();
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
