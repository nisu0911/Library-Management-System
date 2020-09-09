using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Entity;

namespace LMS
{
    public partial class ManageUser : Form
    {
        BLLUser blu = new BLLUser();
        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            List<UserDetails> lst = new List<UserDetails>();
            dataGridView1.DataSource = blu.getUsers();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserDetails ud = addUserDetails();
            int i = blu.addUser(ud);
            if (i > 0)
            {
                MessageBox.Show("User Added Succesfully");
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
            loadGrid();
        }

        private UserDetails addUserDetails()
        {
            UserDetails ud = new UserDetails();
            ud.FullName = txtFullname.Text;
            ud.Username = txtUsername.Text;
            ud.UserType = cboUsertype.Text;
            ud.Password = txtPassword.Text;
            return ud;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserDetails ud = addUserDetails();
            ud.UserID = userID;
            int i=blu.updateUser(ud);
            if (i > 0)
            {
                MessageBox.Show("User Updated Succesfully");
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
            loadGrid();
        }
        int userID = 0;
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UserDetails ud = new UserDetails();
            userID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            txtUsername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cboUsertype.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFullname.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserDetails ud = new UserDetails();
            ud.UserID = userID;
            int i = blu.deleteUser(ud);
            if (i > 0)
            {
                MessageBox.Show("User Deleted");
            }
            else
            {
                MessageBox.Show("Operation failed");
            }
            loadGrid();
        }
    }
}
