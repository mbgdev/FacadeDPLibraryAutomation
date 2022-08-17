using BusinessLogicLayer.BL;
using DataAccessLayer.Connection;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FrmBook
{
    public partial class Frm_Book : Form
    {
        public Frm_Book()
        {
            InitializeComponent();
        }

        private void Frm_Book_Load(object sender, EventArgs e)
        {
            CategoryComboBoxGet();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
           
            
            dataGridView1.DataSource=BLBook.BLBookList();
            this.dataGridView1.Columns["CategoryId"].Visible = false;
            this.dataGridView1.Columns["CategoryName"].DisplayIndex = 3;
            this.dataGridView1.Columns["BookPageCount"].DisplayIndex = 4;
          
        }

        private void btnUnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLBook.BLBookUnList();
            this.dataGridView1.Columns["CategoryId"].Visible = false;
            this.dataGridView1.Columns["CategoryName"].DisplayIndex = 3;
            this.dataGridView1.Columns["BookPageCount"].DisplayIndex = 4;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Books book = new Books();

            book.BookName = txtName.Text;
            book.BookAuthor=txtAuthor.Text;
            book.BookPageCount = int.Parse(txtPAgeCount.Text);
            book.BookType=txtType.Text;
            book.CategoryId = (int)comboBoxCategory.SelectedValue;

            if (rbActive.Checked == true)
            {
                book.BookStatus = true;
            }
            else if (rbPasive.Checked == true)
            {
                book.BookStatus = false;

            }
            else
            {
                book.BookStatus = false;

            }

            BLBook.BLAddBook(book);

        }



        private void CategoryComboBoxGet()
        {
            DBConnection.sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", DBConnection.sqlConnection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            
            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = dataTable;
            DBConnection.sqlConnection.Close();
        }

    
    }
}
