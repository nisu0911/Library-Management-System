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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BLLUser blu = new BLLUser();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDetails ud = new UserDetails();
            ud.Username = txtUsername.Text;
            ud.Password = txtPassword.Text;
            ud.UserType = cboUserType.Text;
            int i=blu.verifyUser(ud);
            if (i > 0)
            {
                MainFrame frm = new MainFrame();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}
