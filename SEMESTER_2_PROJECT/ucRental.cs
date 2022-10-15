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
    public partial class ucRental : UserControl
    {
        public ucRental()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            r.PropertyTenantID = cmbPropertyTenantID.SelectedItem.ToString();
            r.TenantID = cmbPropertyTenantID.SelectedItem.ToString();
            r.StartDate = dtaStartdate.ToString();
            r.EndDate = dtaEndDate.ToString();
            int x = bll.AddRental(r);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            r.StartDate = dtaStartdate.ToString();
            r.EndDate = dtaEndDate.ToString();
            int x = bll.UpdateRental(r);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Updated.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.GetRental();
        }

        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvRental.SelectedRows.Count>0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmbPropertyTenantID.SelectedText = dgvRental.SelectedRows[0].Cells["PropertyTenantID"].Value.ToString();
                cmbTenantID.SelectedText = dgvRental.SelectedRows[0].Cells["TenantID"].Value.ToString();
                dtaStartdate.Text = dgvRental.SelectedRows[0].Cells["StartDate"].Value.ToString();
                dtaEndDate.Text = dgvRental.SelectedRows[0].Cells["EndDate"].Value.ToString();
            }
        }

        private void ucRental_Load(object sender, EventArgs e)
        {
            cmbPropertyTenantID.DataSource = bll.GetPropertyAgent();
            cmbPropertyTenantID.DisplayMember = "Date";
            cmbPropertyTenantID.ValueMember = "PropertyAgentID";

            cmbTenantID.DataSource = bll.GetTenant();
            cmbTenantID.DisplayMember = "Name";
            cmbTenantID.ValueMember = "TenantID";
        }
    }
}
