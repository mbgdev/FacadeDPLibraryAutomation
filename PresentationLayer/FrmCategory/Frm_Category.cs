using BusinessLogicLayer.BL;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.FrmCategory
{
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Category> categories = BLCategory.BLCategoryList();

            dataGridView.DataSource = categories;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            category.CategoryName = txtName.Text;

            if (rbActive.Checked == true)
            {
                category.CategoryStatus = true;
            }
            else if (rbPasive.Checked == true)
            {
                category.CategoryStatus = false;

            }
            else
            {
                category.CategoryStatus = false;

            }

            BLCategory.BLCategoryAdd(category);



        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            category.CategoryId = int.Parse(txtId.Text);

            category.CategoryName = txtName.Text;

            if (rbActive.Checked == true)
            {
                category.CategoryStatus = true;
            }
            else if (rbPasive.Checked == true)
            {
                category.CategoryStatus = false;

            }
            else
            {
                category.CategoryStatus = false;

            }


            BLCategory.BLCategoryUpdate(category);


        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectRowColoum = dataGridView.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView.Rows[selectRowColoum].Cells[0].Value.ToString();
            txtName.Text = dataGridView.Rows[selectRowColoum].Cells[1].Value.ToString();

            string rbStatus = dataGridView.Rows[selectRowColoum].Cells[2].Value.ToString();

            if (rbStatus == "True")
                rbActive.Checked = true;
            else
                rbPasive.Checked = false;

        }
    }
}
