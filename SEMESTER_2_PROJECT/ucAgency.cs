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
using System.Xml.Linq;

namespace SEMESTER_2_PROJECT
{
    public partial class ucAgency : UserControl
    {
        public ucAgency()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agency a = new Agency();
            a.AgencyName = txtAgencyName.Text;
            a.SurbubID = cmbSurbubID.SelectedText.ToString();

            int x = bll.AddAgency(a);

            if (x > 0)
            {
                MessageBox.Show(x + "" + "Added.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.GetAgency();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency a = new Agency();
            a.AgencyID = int.Parse(txtAgencyID.Text);
            int x = bll.DeleteAgency(a);
            if (x > 0)
            {
                MessageBox.Show(x + "" + "Deleted.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucAgency_Load(object sender, EventArgs e)
        {
            cmbSurbubID.DataSource = bll.GetSurbub();
            cmbSurbubID.DisplayMember = "SurbubDescription";
            cmbSurbubID.ValueMember = "SurbubID";

        }

        private void dgvAgency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAgency.SelectedRows.Count>0)
            {
                txtAgencyID.Text = dgvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtAgencyName.Text = dgvAgency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmbSurbubID.SelectedText = dgvAgency.SelectedRows[0].Cells["Surbub"].Value.ToString();
            }
        }
        public void btnHardDelete_Click(Object sender, EventArgs e)
        {
            Agency a = new Agency();
            a.AgencyID = int.Parse(txtAgencyID.Text);
            int x = bll.DeleteAgency(a);
        }
    }
}
