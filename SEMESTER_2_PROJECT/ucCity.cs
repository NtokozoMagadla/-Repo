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
    public partial class ucCity : UserControl
    {
        public ucCity()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            City c = new City();
            c.CityDesc = txtCityDesc.Text;
            c.ProvinceID = cmbProvinceID.SelectedText.ToString();
            int x = bll.AddCity(c);
            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = bll.GetCity();
        }

        private void dgvCity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCity.SelectedRows.Count>0)
            {
                txtCityID.Text = dgvCity.SelectedRows[0].Cells["CityID"].Value.ToString();
                txtCityDesc.Text = dgvCity.SelectedRows[0].Cells["CityDescription"].Value.ToString();
                cmbProvinceID.Text = dgvCity.SelectedRows[0].Cells["ProvinceID"].Value.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucCity_Load(object sender, EventArgs e)
        {
            cmbProvinceID.DataSource = bll.GetProvince();
            cmbProvinceID.DisplayMember = "Description";
            cmbProvinceID.ValueMember = "ProvinceID";


        }
    }
}
