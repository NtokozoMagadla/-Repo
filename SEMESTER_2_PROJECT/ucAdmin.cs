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
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucAdmin_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
        }

        private void btnSoft_Click(object sender, EventArgs e)
        {
            int UserrID = int.Parse(txtAdminID.Text);

            int x = bll.SoftDelete(UserrID);
            if (x > 0)
            {
                MessageBox.Show("User has been made in-active.");
                dgvAdmin.DataSource = bll.GetUser();
            }
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            int UserrID = int.Parse(txtAdminID.Text);

            int x = bll.HardDelete(UserrID);
            if (x > 0)
            {
                MessageBox.Show("User has been deleted.");
                dgvAdmin.DataSource = bll.GetUser();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            a.Name = txtName.Text;
            a.Surname = txtSurname.Text;
            a.Email = txtEmail.Text;
            a.Password = txtPassword.Text;
            a.Phone = txtPhone.Text;
            a.Status = cmbStatus.SelectedText.ToString();

            int x = bll.AddAdmin(a);

            if (x > 0)
            {
                MessageBox.Show(x + "" + "Added.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAdmin.DataSource = bll.GetAdmin();
        }
    }
}
