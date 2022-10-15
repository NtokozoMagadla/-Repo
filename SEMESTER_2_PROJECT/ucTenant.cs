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
    public partial class ucTenant : UserControl
    {
        public ucTenant()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.Name = txtName.Text;
            t.Surname = txtSurname.Text;
            t.Email = txtEmail.Text;
            t.Password = txtPassword.Text;
            t.Phone = txtPhone.Text;
            t.Status = cmbStatus.SelectedText.ToString();
            int x = bll.AddTenant(t);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.Email = txtEmail.Text;
            t.Phone = txtPhone.Text;
            t.Status = cmbStatus.SelectedText.ToString();
            int x = bll.UpdateTenant(t);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Updated.");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.GetTenant();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.TenantID = int.Parse(txtTenantID.Text);
            int x = bll.DeleteTenant(t);

            if (x > 0)
            {
                MessageBox.Show(x + "" + "Deleted.");
            }
        }

        private void dgvTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            { 

                txtTenantID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.SelectedText = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.SelectedText = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }

        private void ucTenant_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
        }
    }
}
