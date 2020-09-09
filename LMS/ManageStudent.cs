using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Entity;

namespace LMS
{
    public partial class ManageStudent : Form
    {
        BLLStudent bls = new BLLStudent();
        public ManageStudent()
        {
            InitializeComponent();
        }
        string defaultpath = "";
        string browsepath = "";
        private void ManageStudent_Load(object sender, EventArgs e)
        {
            loadGrid();
            defaultpath = Application.StartupPath + "\\Noimage.png";
            pictureBox1.ImageLocation = defaultpath;
        }

        private void loadGrid()
        {
            List<BookDetails> lst = new List<BookDetails>();
            dataGridView1.DataSource = bls.getStudents();
        }
        MemoryStream ms;
        byte[] photo_aray;
        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.FullName = txtFullname.Text;
            sd.Email = txtEmail.Text;
            sd.PhoneNo = txtPhoneNo.Text;
            sd.Gender = rbdMale.Checked ? "Male" : "Female";
            sd.RollNo = txtRollNo.Text;
            //image convertion from jpg to byte
            ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);
            sd.Photo = photo_aray.ToString();
            int i = bls.addStudent(sd);
            if (i > 0)
            {
                MessageBox.Show("Student Added");
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
            loadGrid();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Images *.jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                browsepath = openFileDialog1.FileName;
                pictureBox1.ImageLocation = browsepath;

            }
        }
    }
}
