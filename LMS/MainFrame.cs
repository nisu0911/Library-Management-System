using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.MdiParent = this;
            frm.Show();
        }

        private void manageBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageBook frm = new ManageBook();
            frm.MdiParent = this;
            frm.Show();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudent frm = new ManageStudent();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
