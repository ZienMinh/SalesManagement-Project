using BusinessObject;
using DataAccess.Repository;

namespace VienMinh.SalesManagementProject
{
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        public Member checkMember { get; set; }
        public frmMembers()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var member = GetMemberObject();
            try
            {
                if (member != null)
                {
                    if (memberRepository.CheckEmailDeplicate(member.Email))
                    {
                        memberRepository.InsertMember(member);
                        LoadMemberList();
                        MessageBox.Show("Add member successfullyy");
                    }
                    else
                    {
                        throw new Exception("Add new member fail. Duplicated Email.");
                    }
                }
                else
                {
                    throw new Exception("Add new member fail. Fill in the blank information box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Member");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var member = GetMemberObject();

            try
            {
                if (member != null && txtGmail.Text != null)
                {
                    if (memberRepository.CheckEmailDeplicate(member.Email))
                    {
                        member.MemberId = int.Parse(txtMemberID.Text);
                        memberRepository.UpdateMember(member);
                        LoadMemberList();
                        MessageBox.Show("Update member successfully");
                    }
                    else
                    {
                        throw new Exception("Update member fail. Duplicated email!");
                    }
                }
                else
                {
                    throw new Exception("Update member fail. Fill in the blank information box!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Member");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var memberID = int.Parse(txtMemberID.Text);
                orderRepository.DeleteOrderByMemberID(memberID);
                memberRepository.DeleteMember(memberID);
                LoadMemberList();
                txtMemberID.Clear();
                MessageBox.Show("Delete member successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete member fail. Select a member beside to delete!");
            }
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            LoadMemberList();
            if (!checkMember.Email.Equals("admin@fstore.com"))
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => Close();
        private void dgvMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMemberList.Rows.Count - 1)
            {
                txtMemberID.Text = dgvMemberList.Rows[e.RowIndex].Cells["MemberID"].Value.ToString();
                txtGmail.Text = dgvMemberList.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                txtCompany.Text = dgvMemberList.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                txtCity.Text = dgvMemberList.Rows[e.RowIndex].Cells["City"].Value.ToString();
                txtCountry.Text = dgvMemberList.Rows[e.RowIndex].Cells["Country"].Value.ToString();
                txtPassword.Text = dgvMemberList.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            }
        }

        private Member GetMemberObject()
        {
            Member member = null;
            try
            {
                if (!txtGmail.Text.Equals("") || !txtPassword.Text.Equals(""))
                {
                    member = new Member
                    {
                        Email = txtGmail.Text,
                        CompanyName = txtCompany.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Password = txtPassword.Text,
                    };
                }
                else throw new Exception("Email and Password can not be null!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        private void LoadMemberList()
        {
            try
            {
                var members = new List<Member>();
                if (checkMember.Email.Equals("admin@fstore.com"))
                {
                    members = (List<Member>)memberRepository.GetMembers();
                }
                else
                {
                    members.Add(checkMember);
                }
                source = new BindingSource();
                source.DataSource = members;

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                dgvMemberList.Columns[0].Width = (int)(dgvMemberList.Width * 0.1);
                dgvMemberList.Columns[1].Width = (int)(dgvMemberList.Width * 0.19);
                dgvMemberList.Columns[2].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[3].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[4].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[5].Width = (int)(dgvMemberList.Width * 0.163);
                dgvMemberList.Columns[6].Width = (int)(dgvMemberList.Width * 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
    }
}
