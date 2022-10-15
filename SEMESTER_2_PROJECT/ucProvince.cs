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
    public partial class ucProvince : UserControl
    {
        public ucProvince()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Provinces p = new Provinces();
            p.Description = txtDesc.Text;
            int x = bll.AddProvince(p);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.GetProvince();
        }

        private void dgvProvince_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProvince.SelectedRows.Count>0)
            {
                txtProvinceID.Text = dgvProvince.SelectedRows[0].Cells["ProvinceID"].Value.ToString();
                txtDesc.Text = dgvProvince.SelectedRows[0].Cells["Description"].Value.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
