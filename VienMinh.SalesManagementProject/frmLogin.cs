using DataAccess.Repository;

namespace VienMinh.SalesManagementProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        IMemberRepository memberRepository = new MemberRepository();
        //UI Design Basic, Create file basic for code, Connect Database, 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtGmail.Text;
                string password = txtPassword.Text;
                var checkMember = memberRepository.GetMemberByEmailPassword(email, password);
                if (checkMember != null)
                {
                    MessageBox.Show("Login successfully");
                    frmMain frmMain = new frmMain();
                    frmMain.member = checkMember;
                    frmMain.ShowDialog();
                }
                else
                {
                    throw new Exception("Invalid email or password. Try again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login");
            }

        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
