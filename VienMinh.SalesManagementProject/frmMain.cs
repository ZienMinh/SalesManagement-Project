using BusinessObject;
namespace VienMinh.SalesManagementProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public Member member { get; set; }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers f = new frmMembers();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.checkMember = member;
            f.Show();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (member.Email.Equals("admin@fstore.com"))
            {
                frmProducts f = new frmProducts();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                productManagementToolStripMenuItem.Enabled = false;
                MessageBox.Show("Your role does not support this function", "Normal user role");
            }
        }
        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders f = new frmOrders();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.checkMember = member;
            f.Show();
        }
    }
}
