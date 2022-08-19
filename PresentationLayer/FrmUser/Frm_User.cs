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

namespace PresentationLayer.FrmUser
{
    public partial class Frm_User : Form
    {
        public Frm_User()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLUser.BLUserList();
        }

        private void btnUnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLUser.BLUserUnList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Users users = new Users();

            users.UserNo = int.Parse(txtNo.Text);
            users.UserName = txtName.Text;
            users.UserSurname = txtSurname.Text;
            users.UserPassword=txtPassword.Text;
            users.UserEmail=txtEmail.Text;
            users.UserRole = txtRole.Text;
            users.UserAddress = txtAdress.Text;

            if (rbActive.Checked == true)
            {
                users.UserStatus = true;
            }
            else if (rbPasive.Checked == true)
            {
                users.UserStatus = false;

            }
            else
            {
                users.UserStatus = false;


            }

            BLUser.BLAddUser(users);

        }
    }
}
