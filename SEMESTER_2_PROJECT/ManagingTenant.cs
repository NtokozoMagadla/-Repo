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
    public partial class ManagingTenant : Form
    {
        public ManagingTenant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucTenant1.BringToFront();
        }

        private void ManagingTenant_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucProperty1.BringToFront();
        }
    }
}
