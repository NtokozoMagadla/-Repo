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
    public partial class ucSurbub : UserControl
    {
        public ucSurbub()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Surbub s = new Surbub();
            s.SurbubDesc = txtSurbubDesc.Text;
            s.PostalCode = txtPostalCode.Text;
            s.CityID = cmbCityID.SelectedText.ToString();
            int x = bll.AddSurbub(s);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvSurbub.DataSource = bll.GetSurbub();
        }

        private void dgvSurbub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvSurbub.SelectedRows.Count>0)
            {
                txtSurbubID.Text = dgvSurbub.SelectedRows[0].Cells["SurbubID"].Value.ToString();
                txtSurbubDesc.Text = dgvSurbub.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                txtPostalCode.Text = dgvSurbub.SelectedRows[0].Cells["PostalCode"].Value.ToString();
                cmbCityID.SelectedText = dgvSurbub.SelectedRows[0].Cells["CityID"].Value.ToString();
            }
        }

        private void ucSurbub_Load(object sender, EventArgs e)
        {
            cmbCityID.DataSource = bll.GetCity();
            cmbCityID.DisplayMember = "CityDescription";
            cmbCityID.ValueMember = "CityID";

            

        }

            
    }
}
