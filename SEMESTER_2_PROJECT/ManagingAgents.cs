using DAL.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEMESTER_2_PROJECT
{
    public partial class ManagingAgents : Form
    {
        public ManagingAgents()
        {
            InitializeComponent();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            ucProperty1.BringToFront();
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            ucRental1.BringToFront();
        }

        private void btnPropertyAgent_Click(object sender, EventArgs e)
        {
            ucPropertyAgent1.BringToFront();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            ucPropertyType1.BringToFront();
        }
    }
}
