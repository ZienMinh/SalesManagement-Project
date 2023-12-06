using BusinessObject;
using DataAccess.Repository;
using System.Data;
using System.Windows.Forms;
using VienMinh.SalesManagementProject;

namespace VienMinh.SalesManagementProject
{
    public partial class frmOrders : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public Member checkMember { get; set; }
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = GetOrderObject();
            try
            {
                if (order != null)
                {
                    orderRepository.InsertOrder(order);
                    LoadOrderList();
                    LoadCbMemberID();
                    MessageBox.Show("Add new order successfully");
                }
                else
                {
                    throw new Exception("Add new order fail. Fill in the blank information box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add order");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var orderID = int.Parse(txtOrderID.Text);
                orderRepository.DeleteOrder(orderID);
                LoadOrderList();
                LoadCbMemberID();
                txtOrderID.Clear();
                MessageBox.Show("Delete order successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete order fail. Select an order beside to delete!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var order = GetOrderObject();
            try
            {
                if (order != null)
                {
                    order.OrderId = int.Parse(txtOrderID.Text);
                    orderRepository.UpdateOrder(order);
                    LoadOrderList();
                    LoadCbMemberID();
                    MessageBox.Show("Update order successfully");
                }
                else
                {
                    throw new Exception("Update order fail. Select an order beside to update!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update order");
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void frmOrders_Load(object sender, EventArgs e)
        {
            LoadOrderList();
            if (!checkMember.Email.Equals("admin@fstore.com"))
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                button1.Enabled = false;
            }
            else
            {
                LoadCbMemberID();
            }
        }
        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOrderID.Text != null && txtOrderID.Text != "")
                {
                    int orderID = int.Parse(txtOrderID.Text);
                    frmOrderDetail f = new frmOrderDetail();
                    f.orderID = orderID;
                    f.ShowDialog();
                }
                else
                    throw new Exception("Invalid orderID");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "More Detail");
            }
        }
        private Order GetOrderObject()
        {
            Order order = null;
            try
            {
                if (CheckMemberIDValid())
                {
                    order = new Order
                    {
                        MemberId = int.Parse(cbMemberID.Text),
                        Freight = decimal.Parse(txtFreight.Text),
                        OrderDate = dtpOrderDate.Value,
                        RequiredDate = dtpRequiredDate.Value,
                        ShippedDate = dtpShippedDate.Value,
                    };
                }
                else
                {
                    throw new Exception("The memberID doesn't exist. Try other values in the box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return order;
        }

        private bool CheckMemberIDValid()
        {
            int checkMemberID = int.Parse(cbMemberID.Text);
            var checkMember = memberRepository.GetMemberByID(checkMemberID);
            if (checkMember != null)
            {
                return true;
            }
            return false;
        }

        private void LoadOrderList()
        {
            try
            {
                var orders = new List<Order>();

                if (checkMember.Email.Equals("admin@fstore.com"))
                {
                    orders = (List<Order>)orderRepository.GetOrders();
                }
                else
                {
                    orders = (List<Order>)orderRepository.GetOrdersByMemberID(checkMember.MemberId);
                }
                source = new BindingSource();
                source.DataSource = orders;

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;

                dgvOrderList.Columns[0].Width = (int)(dgvOrderList.Width * 0.1);
                dgvOrderList.Columns[1].Width = (int)(dgvOrderList.Width * 0.1);
                dgvOrderList.Columns[2].Width = (int)(dgvOrderList.Width * 0.2);
                dgvOrderList.Columns[3].Width = (int)(dgvOrderList.Width * 0.2);
                dgvOrderList.Columns[4].Width = (int)(dgvOrderList.Width * 0.2);
                dgvOrderList.Columns[5].Width = (int)(dgvOrderList.Width * 0.14);
                dgvOrderList.Columns[6].Width = (int)(dgvOrderList.Width * 0);
                dgvOrderList.Columns[7].Width = (int)(dgvOrderList.Width * 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void LoadCbMemberID()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = orderRepository.GetMemberID();

                cbMemberID.DataSource = null;
                cbMemberID.DataSource = source;
                cbMemberID.DisplayMember = "MemberID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load memberID list");
            }
        }

        private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvOrderList.Rows.Count - 1)
            {
                txtOrderID.Text = dgvOrderList.Rows[e.RowIndex].Cells["OrderID"].Value.ToString();
                cbMemberID.Text = dgvOrderList.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
                txtFreight.Text = dgvOrderList.Rows[e.RowIndex].Cells["Freight"].Value.ToString();
                dtpOrderDate.Text = dgvOrderList.Rows[e.RowIndex].Cells["OrderDate"].Value.ToString();
                dtpRequiredDate.Text = dgvOrderList.Rows[e.RowIndex].Cells["RequiredDate"].Value.ToString();
                dtpShippedDate.Text = dgvOrderList.Rows[e.RowIndex].Cells["ShippedDate"].Value.ToString();
            }
        }

        private void dgvOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderID = 0;
            if (e.RowIndex >= 0 && e.RowIndex < dgvOrderList.Rows.Count - 1)
            {
                orderID = int.Parse(dgvOrderList.Rows[e.RowIndex].Cells["OrderID"].Value.ToString());
            }
            frmOrderDetail f = new frmOrderDetail();
            f.orderID = orderID;
            f.ShowDialog();
        }
        //Tri
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value.Date;
            DateTime end = dateTimePicker2.Value.Date;

            var orders = orderRepository.Search(x => x.OrderDate >= start.AddMinutes(-100) && x.OrderDate <= end).ToList();
            var res = from order in orders
                      orderby order.OrderDate descending
                      select order;
            dgvOrderList.DataSource = res.ToList();
        }
        //Tri
    }
}
