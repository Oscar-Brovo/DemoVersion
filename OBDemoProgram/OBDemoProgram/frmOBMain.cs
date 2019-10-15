using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace OBDemoProgram
{
    public partial class frmOBMain : Form
    {
        public frmMenu menu;
        public frmOBList obList;
        public PersonClass personClassAdminForm;
        public OcurranceBookClass OBEntry = new OcurranceBookClass();
        public string toStringDisplay = "OBMain";

        public frmOBMain()
        {
            InitializeComponent();
        }

        private void frmOBMain_Load(object sender, EventArgs e)
        {
            ReloadOBForm();
        }

        public void ReloadOBForm()
        {
           // OBEntry = new OcurranceBookClass();
            SiteClass site = new SiteClass();
            OfficerClass officer = new OfficerClass();
            ConstantClass.ToStringType = "OBCombo";


            OBEntry.PopulateOBList();
            lblReturnOBnumber.Text = OBEntry.GetNewReturnOBNumber();
            cmbSite.DataSource = site.GetSiteData();
            cmbOfficer.DataSource = officer.GetOfficerData();
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss");
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtOBNumber.Text = "";
            txtOccurenceNote.Text = "";
            cmbOccurence.SelectedIndex = -1;
            cmbOfficer.SelectedIndex = -1;
            cmbShift.SelectedIndex = -1;
            cmbSite.SelectedIndex = -1;

            txtOBNumber.Enabled = true;
            txtOccurenceNote.Enabled = true;
            cmbOccurence.Enabled = true;
            cmbOfficer.Enabled = true;
            cmbShift.Enabled = true;
            cmbSite.Enabled = true;
        }

        public void ClearOBForm()
        {
            txtOBNumber.Text = "";
            txtOccurenceNote.Text = "";
            txtDate.Text = "";
            txtTime.Text = "";
            cmbOccurence.SelectedIndex = -1;
            cmbOfficer.SelectedIndex = -1;
            cmbShift.SelectedIndex = -1;
            cmbSite.SelectedIndex = -1;

            txtOBNumber.Enabled = false;
            txtOccurenceNote.Enabled = false;
            cmbOccurence.Enabled = false;
            cmbOfficer.Enabled = false;
            cmbShift.Enabled = false;
            cmbSite.Enabled = false;
        }
        
        public bool TestForString(string data)
        {
            if (data != "")
            {
                return true;
            }
            return false;
        }

        public bool TestForIntAndCmb(string data)
        {
            try
            {
                if (data == "") return false;
                int intData = int.Parse(data);
                if (intData == -1)
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }

        private void btnLogEntry_Click(object sender, EventArgs e)
        {
            string AddorUpdate = "";
            if (btnLogEntry.Text == "")
            {
                AddorUpdate = "added";
            }
            else
            {
                AddorUpdate = "updated";
            }
           if(btnLogEntry.Text == "Add New Entry")
            {
                ReloadOBForm();
            }
            else
            {
                bool flag = true;
                string rOBNum = lblReturnOBnumber.Text;
                string oBNum = txtOBNumber.Text;
                string occurence = "";
                string shift = "";
                string siteCallSign = "";
                string officer = "";
                try
                {
                    occurence = cmbOccurence.SelectedItem.ToString();
                    shift = cmbShift.SelectedItem.ToString();
                    siteCallSign = ((SiteClass)cmbSite.SelectedItem).Callsighn;
                    officer = ((OfficerClass)cmbOfficer.SelectedItem).PSiRA;
                }
                catch (Exception)
                { flag = false; }
                string theDate = txtDate.Text;
                string theTime = txtTime.Text;
                string notes = txtOccurenceNote.Text;


                if (TestForIntAndCmb(rOBNum) && TestForIntAndCmb(oBNum) && TestForString(notes) && flag)
                {
                    OBEntry = new OcurranceBookClass((rOBNum + "#" + theDate), int.Parse(rOBNum), int.Parse(oBNum), shift, siteCallSign, occurence, notes, int.Parse(officer), theDate + "#" + theTime);
                    if (OBEntry.RecordEntry())
                    {
                        MessageBox.Show("Record has been "+AddorUpdate);
                        ClearOBForm();
                        btnLogEntry.Text = "Add New Entry";
                    }
                    else
                    {
                        MessageBox.Show("Entry Failed to be "+AddorUpdate);
                    }
                }
                else
                {
                    MessageBox.Show("Make sure that all fields are filled in correctly");
                }
            }

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(ConstantClass.Programflow == 1)
            {
                menu.Show();
                ConstantClass.Programflow = 0;
                this.Close();
            }
            if(ConstantClass.Programflow == 2)
            {
                obList.Show();
                ConstantClass.Programflow = 0;
                this.Close();
            }
        }

        ////
        
        public void PopulateUpdateData()
        {
            ReloadOBForm();

            lblReturnOBnumber.Text = OBEntry.Rob.ToString();
            txtOBNumber.Text = OBEntry.Ob.ToString();
            txtTime.Text = OBEntry.DateAndTime.Split('#')[1];
            txtDate.Text = OBEntry.DateAndTime.Split('#')[0];
            cmbOccurence.SelectedIndex = cmbOccurence.FindStringExact(OBEntry.Occurence);
            cmbShift.SelectedIndex = cmbShift.FindString(OBEntry.Shifts);
            int finalIndex = -1;
            int index = 0;
            foreach (OfficerClass item in cmbOfficer.Items)
            {
                if (item.PSiRA == OBEntry.Officer.ToString())
                {
                    finalIndex = index;
                }
                index++;
            }
            cmbOfficer.SelectedIndex = finalIndex;
            index = 0;
            foreach (SiteClass item in cmbSite.Items)
            {
                if (item.Callsighn == OBEntry.Site)
                {
                    finalIndex = index;
                }
                index++;
            }
            cmbSite.SelectedIndex = finalIndex;
            txtOccurenceNote.Text = OBEntry.Notes.Replace("&", Environment.NewLine).Replace("@", ",");
        }

       
    }
}


// Add update 
// check on why active form is null on obList
