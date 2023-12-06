using DataAccess.Repository;

namespace VienMinh.SalesManagementProject
{
    public partial class frmOrderDetail : Form
    {
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        BindingSource source;
        public frmOrderDetail()
        {
            InitializeComponent();
        }
        public int orderID;
        private void btnBack_Click(object sender, EventArgs e) => Close();
        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            LoadOrderDetailList(orderID);
        }
        public void LoadOrderDetailList(int orderId)
        {
            var orderDetails = orderDetailRepository.GetOrderDetails(orderId);
            try
            {
                source = new BindingSource();
                source.DataSource = orderDetails;

                dgvOrderDetailList.DataSource = null;
                dgvOrderDetailList.DataSource = source;

                dgvOrderDetailList.Columns[0].Width = (int)(dgvOrderDetailList.Width * 0.15);
                dgvOrderDetailList.Columns[1].Width = (int)(dgvOrderDetailList.Width * 0.15);
                dgvOrderDetailList.Columns[2].Width = (int)(dgvOrderDetailList.Width * 0.3);
                dgvOrderDetailList.Columns[3].Width = (int)(dgvOrderDetailList.Width * 0.15);
                dgvOrderDetailList.Columns[4].Width = (int)(dgvOrderDetailList.Width * 0.15);
                dgvOrderDetailList.Columns[5].Width = (int)(dgvOrderDetailList.Width * 0);
                dgvOrderDetailList.Columns[6].Width = (int)(dgvOrderDetailList.Width * 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load orderDetail list");
            }
        }
    }
}
