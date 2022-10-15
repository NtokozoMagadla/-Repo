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
    public partial class ucProperty : UserControl
    {
        public ucProperty()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Property p = new Property();
            p.Desc = txtDescription.Text;
            p.Price = double.Parse(txtPrice.Text);
            p.Image = txtImage.Text;
            p.PropertyTypeID = cmbPropertyAgentID.SelectedText.ToString();
            p.Status = cmbStatus.Text;
            p.SurbubID = cmbSurbubID.SelectedText.ToString();
            int x = bll.AddProperties(p);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Property p = new Property();
            p.PropertyID = int.Parse(txtPropertyID.Text);
            p.Price = double.Parse(txtPrice.Text);
            p.Status = cmbStatus.Text;
            int x = bll.UpdateProperty(p);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Updated.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.GetProperties();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Property p = new Property();
            p.PropertyID = int.Parse(txtPropertyID.Text);
            int x = bll.DeleteProperty(p);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Deleted.");
            }
        }

        private void dgvProperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProperty.SelectedRows.Count>0)
            {
                txtPropertyID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtDescription.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtImage.Text = dgvProperty.SelectedRows[0].Cells["Image"].Value.ToString();
                cmbPropertyAgentID.SelectedText = dgvProperty.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbStatus.SelectedText= dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSurbubID.SelectedText = dgvProperty.SelectedRows[0].Cells["SurbubID"].Value.ToString();
            }
        }

        private void ucProperty_Load(object sender, EventArgs e)
        {
            cmbSurbubID.DataSource = bll.GetPropertyAgent();
            cmbSurbubID.DisplayMember = "Date";
            cmbSurbubID.ValueMember = "PropertyAgentID";

            cmbSurbubID.DataSource = bll.GetSurbub();
            cmbSurbubID.DisplayMember = "SurbubDescription";
            cmbSurbubID.ValueMember = "SurbubID";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
        }
    }
}
