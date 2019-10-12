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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string pass = txtPassword.Text;
            
            if(username != "" && pass != "")
            {
                PersonClass personClass = new PersonClass(username,pass);
                personClass.PopulatingList();
                if (personClass.LoginMethod())
                {
                    frmMenu menuForm = new frmMenu();
                    menuForm.personClass = personClass;
                    menuForm.Show();
                    menuForm.tempFrmHolder = (frmLogin)Form.ActiveForm;
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("Password and Username doesn't match");
                }

            }

        }
    }
}
