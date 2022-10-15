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
    public partial class ucAgent : UserControl
    {
        public ucAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agent ag = new Agent();
            ag.Name = txtName.Text;
            ag.Surname = txtSurname.Text;
            ag.Email = txtEmail.Text;
            ag.Password = txtPassword.Text;
            ag.Status = cmbStatus.SelectedText.ToString();
            ag.AgencyID = cmbAgencyID.SelectedText.ToString();
            int x = bll.AddAgent(ag);

            if (x > 0)
            {
                MessageBox.Show(x +""+ " Added.");
            }
        }

        private void btnDislpay_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.GetAgent();
        }

        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAgent.SelectedRows.Count > 0)
            {
                txtAgentID.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbStatus.SelectedText = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgencyID.SelectedText = dgvAgent.SelectedRows[0].Cells["AgencyID"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Agent ag = new Agent();
            ag.Email = txtEmail.Text;
            ag.Password = txtPassword.Text;
            ag.Status = cmbStatus.SelectedText.ToString();
            int x = bll.UpdateAgent(ag);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Updated.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agent ag = new Agent();
            ag.AgentID = int.Parse(txtAgentID.Text);
            int x = bll.DeleteAgent(ag);

            if (x > 0)
            {
                MessageBox.Show(x + "" + " Deleted.");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucAgent_Load(object sender, EventArgs e)
        {
            cmbAgencyID.DataSource = bll.GetAgency();
            cmbAgencyID.DisplayMember = "AgencyName";
            cmbAgencyID.ValueMember = "AgencyID";

            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");

        }
    }
}
