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
    public partial class frmOBList : Form
    {
        public frmMenu menu;
        public PersonClass personClassAdminForm;
        private frmOBMain obmain;


        public frmOBList()
        {
            InitializeComponent();
        }

        private void frmOBList_Load(object sender, EventArgs e)
        {
            OcurranceBookClass obclass = new OcurranceBookClass();
            obclass.PopulateOBList();
            lstOBList.DataSource = null;
            lstOBList.DataSource = obclass.obList;
        }

        private void btnViewEntry_Click(object sender, EventArgs e)
        {
           obmain = new frmOBMain();

             obmain.obList = (frmOBList)Form.ActiveForm;
            if (lstOBList.SelectedIndex != -1)
            {
                obmain.OBEntry = (OcurranceBookClass)lstOBList.SelectedItem;
            }
            else
            {
                MessageBox.Show("Please select a entry");
            }
            ConstantClass.Programflow = 2;
            obmain.personClassAdminForm = personClassAdminForm;
            obmain.Show();
            obmain.PopulateUpdateData();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
