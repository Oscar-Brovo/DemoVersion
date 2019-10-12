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
    }
}
