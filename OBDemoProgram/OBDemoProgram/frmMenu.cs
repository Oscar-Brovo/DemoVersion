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
    public partial class frmMenu : Form
    {
        public PersonClass personClass = new PersonClass();
        public frmLogin tempFrmHolder;

        public frmMenu()
        {
            InitializeComponent();
        }

        public void RankExecution()
        {
            switch (personClass.Rank)
            {
                case 0:
                    {
                        btnAdminPanel.Hide();
                        btnLogOut.Hide();
                        btnNewOB.Hide();
                        btnOBList.Hide();
                        this.Close();
                    }break;
                case 1:
                    {
                        btnAdminPanel.Hide();
                        tempFrmHolder.Hide();
                    }
                    break;
                case 2:
                    {

                        tempFrmHolder.Hide();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            tempFrmHolder.Show();
            this.Close();
        }
    }
}
