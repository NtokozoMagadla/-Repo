using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DataAccessLayer;
using BLL.BusinessLogicLayer;

namespace SEMESTER_2_PROJECT
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.Login(txtEmail.Text, txtPassword.Text);


            if (dt.Rows.Count > 0)
            {
                string role = dt.Rows[0]["RoleDescription"].ToString();

                if (role == "Admin")
                {
                    ManagingAdministrator form = new ManagingAdministrator();
                    form.Show();
                    this.Hide();
                }
                else if (role == "Tenant")
                {
                    ManagingTenant form = new ManagingTenant();
                    form.Show();
                    this.Hide();
                }
                else if (role == "Agent")
                {
                    ManagingTenant form = new ManagingTenant();
                    form.Show();
                    this.Hide();
                }

            }
            else if (dt.Rows.Count == 0)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                lblWrong.Visible = true;

            }

        }
            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }
    }
}

