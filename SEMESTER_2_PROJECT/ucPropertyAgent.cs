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
    public partial class ucPropertyAgent : UserControl
    {
        public ucPropertyAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            pa.PropertyID = cmbPropertyID.SelectedText.ToString();
            pa.AgentID = cmbAgentID.SelectedText.ToString();
            pa.Date = dtaPropertyAgent.Text;
            int x = bll.AddPropertyAgent(pa);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Added.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            pa.PropertyID = cmbPropertyID.SelectedText.ToString();
            pa.AgentID = cmbAgentID.SelectedText.ToString();
            pa.Date = dtaPropertyAgent.Text;
            int x = bll.UpdatePropertyAgent(pa);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Updated.");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyAgent.DataSource = bll.GetPropertyAgent();
        }

        private void dgvPropertyAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPropertyAgent.SelectedRows.Count>0)
            {
                txtPropertyAgentID.Text = dgvPropertyAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbPropertyID.SelectedText = dgvPropertyAgent.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                cmbAgentID.SelectedText = dgvPropertyAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                dtaPropertyAgent.Text= dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();
                
                
            }
        }

        private void ucPropertyAgent_Load(object sender, EventArgs e)
        {
            cmbPropertyID.DataSource = bll.GetProperties();
            cmbPropertyID.DisplayMember = "Description";
            cmbPropertyID.ValueMember = "PropertyID";

            cmbAgentID.DataSource = bll.GetAgent();
            cmbAgentID.DisplayMember = "Name";
            cmbAgentID.ValueMember = "AgentID";
        }
    }
}
