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
        public PersonClass personClassMenu = new PersonClass();
        public frmLogin tempFrmHolder;

        public frmMenu()
        {
            InitializeComponent();
        }
    

        public void RankExecution()
        {
           switch (personClassMenu.Rank)
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
       
        private void btnNewOB_Click(object sender, EventArgs e)
        {
            ConstantClass.Programflow = 1;
            frmOBMain frmOB = new frmOBMain();
            frmOB.personClassAdminForm = personClassMenu;
            frmOB.menu = (frmMenu)Form.ActiveForm;
            frmOB.Show();
            this.Hide();
        }
       
        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            frmAdminPanel frmAdmin = new frmAdminPanel();
            frmAdmin.personClassAdminForm = personClassMenu;
            frmAdmin.menu = (frmMenu)Form.ActiveForm;
            frmAdmin.Show();
            this.Hide();
       
        }
       
        private void btnOBList_Click(object sender, EventArgs e)
        {
            ConstantClass.Programflow = 2;
            frmOBList frmOBLst = new frmOBList();
            frmOBLst.personClassAdminForm = personClassMenu;
            frmOBLst.menu = (frmMenu)Form.ActiveForm;
            frmOBLst.Show();
            this.Hide();
        }
    }
}
