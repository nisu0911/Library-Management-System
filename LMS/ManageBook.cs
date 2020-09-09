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
    public partial class ManageBook : Form
    {
        BLLBook blb = new BLLBook();
        public ManageBook()
        {
            InitializeComponent();
        }
        string defaultpath = "";
        string browsepath = "";
        private void ManageBook_Load(object sender, EventArgs e)
        {
            defaultpath = Application.StartupPath + "\\Noimage.png";
            pictureBox1.ImageLocation = defaultpath;
            loadGrid();
        }
        private void loadGrid()
        {
            List<BookDetails> lst = new List<BookDetails>();
            dataGridView1.DataSource = blb.getBooks();
        }
        MemoryStream ms;
        byte[] photo_aray;

        private void btnSace_Click(object sender, EventArgs e)
        {
            BookDetails bd = new BookDetails();
            StockDetails sd = new StockDetails();
            bd.BookName = txtBookName.Text;
            bd.Author = txtAuthorName.Text;
            bd.ISBN = txtISBN.Text;
            sd.Quantity = Convert.ToInt32(txtQuantity.Text);
            bd.AddedDate = DateTime.Today.ToShortDateString();
            bd.IsReference = (chkIsReference.Checked ? true : false).ToString();
            //image convertion from jpg to byte
            ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);

            bd.Photo = photo_aray;
            int i = blb.addBook(bd, sd);
            if (i > 0)
            {
                MessageBox.Show("Book/s Added Succesfully");
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
        int bookID = 0;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookDetails ud = new BookDetails();
            bookID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ud = blb.getBookByID(bookID);
            txtAuthorName.Text = ud.Author;
            txtBookName.Text = ud.BookName;
            txtISBN.Text = ud.ISBN;
            photo_aray = (byte[])ud.Photo;
            MemoryStream ms = new MemoryStream(photo_aray);
            pictureBox1.Image = Image.FromStream(ms);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BookDetails bd = new BookDetails();
            bd.Author = txtAuthorName.Text;
            bd.BookName = txtBookName.Text;
            bd.ISBN = txtISBN.Text;
            bd.IsReference = (chkIsReference.Checked ? true : false).ToString();
            ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            byte[] photo_aray = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(photo_aray, 0, photo_aray.Length);
            bd.Photo = photo_aray;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BookDetails bd = new BookDetails();
            bd.BookID = bookID;
            int i=blb.deleteBook(bd);
            if (i > 0)
            {
                MessageBox.Show("Book Deleted");
            }
            else
            {
                MessageBox.Show("Operation Failed");
            }
        }
    }
}
