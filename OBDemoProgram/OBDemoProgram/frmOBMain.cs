using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBDemoProgram
{
    public partial class frmOBMain : Form
    {
        public frmMenu menu;
        public PersonClass personClassAdminForm;

        public frmOBMain()
        {
            InitializeComponent();
        }

        public int GetReturnOBNumber()
        {
            return 1;
        }

        private void btnLogEntry_Click(object sender, EventArgs e)
        {

        }
    }
}
