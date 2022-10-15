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
    public partial class ucPropertyType : UserControl
    {
        public ucPropertyType()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyType pt = new PropertyType();
            pt.PropertyTypeDesc = txtPropertyTypeDesc.Text;
            int x = bll.AddPropertyType(pt);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyType.DataSource = bll.GetPropertyType();
        }

        private void dgvPropertyType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPropertyType.SelectedRows.Count>0)
            {
                txtPropertyTypeID.Text = dgvPropertyType.SelectedRows[0].Cells["PropertyTyeID"].Value.ToString();
                txtPropertyTypeDesc.Text = dgvPropertyType.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
            }
        }
    }
    
}
