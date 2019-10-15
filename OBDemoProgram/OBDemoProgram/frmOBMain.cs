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
        public OcurranceBookClass OBEntry;
        public string toStringDisplay = "OBMain";

        public frmOBMain()
        {
            InitializeComponent();
        }

        private void frmOBMain_Load(object sender, EventArgs e)
        {
            OBEntry = new OcurranceBookClass();
            SiteClass site = new SiteClass();
            OfficerClass officer = new OfficerClass();
            OBEntry.PopulateOBList();
            lblReturnOBnumber.Text = OBEntry.GetNewReturnOBNumber();

            txtTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            cmbSite.DataSource = site.GetSiteData();
            cmbOfficer.DataSource = officer.GetOfficerData();

        }

        public string converDate(string dateGiven)
        {
            string[] newDate = dateGiven.Split(' ');
            switch (newDate[2])
            {
                case "October": {
                        newDate[2] = "10";
                    } break;
                default:
                    break;
            }

            return newDate[1] + "-" + newDate[2] + "-" + newDate[3];
        }

        private void btnLogEntry_Click(object sender, EventArgs e)
        {
            string rOBNum = lblReturnOBnumber.Text;
            string oBNum = txtOBNumber.Text;
            string shift = cmbShift.SelectedText;
            string siteCallSign = ((SiteClass)cmbSite.SelectedItem).Callsighn;
            string officer = ((OfficerClass)cmbOfficer.SelectedItem).PSiRA;
            string thedate = converDate(dtmDate.Text);
            string occurence = cmbOccurence.SelectedText;
            string notes = txtOccurenceNote.Text;


            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
