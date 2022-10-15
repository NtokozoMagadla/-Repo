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
    public partial class ManagingAdministrator : Form
    {
        public ManagingAdministrator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucProperty1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucPropertyType1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucAgency1.BringToFront();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            ucProvince1.BringToFront();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            ucCity1.BringToFront();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ucAgent1.BringToFront();
        }

        private void btnSurbub_Click(object sender, EventArgs e)
        {
            ucSurbub1.BringToFront();
        }
    }
}
