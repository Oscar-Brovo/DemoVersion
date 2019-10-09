using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OB_0._01
{
    public partial class frmLogin : Form
    {
        PersonClass person;
        public frmLogin()
        {
            InitializeComponent();
            person.PopulatingList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            person = new PersonClass(txtUsername.Text, txtPassword.Text);
            if (person.LoginMethod())
            {
                MessageBox.Show("user found.");
            }
            else
            {
                MessageBox.Show("Fuck you. please try again. :)");
            }
        }
    }
}
