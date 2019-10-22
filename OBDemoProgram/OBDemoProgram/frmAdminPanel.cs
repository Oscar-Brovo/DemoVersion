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
    public partial class frmAdminPanel : Form
    {
        #region Form and help
        public PersonClass personClassAdminForm;
        public OfficerClass officerClass = new OfficerClass();
        public SiteClass siteClass = new SiteClass();
        public PersonClass personClass = new PersonClass();
        public frmMenu menu;

        

        public frmAdminPanel()
        {
            InitializeComponent();
            //officerClass.PopulatingList();
        }

        public bool testField(string field, int testType = 2) // testType 1 = numbers ,  2 = text type
        {
            switch (testType)
            {
                case 1:
                    {
                        if (field != "")
                        {
                            try
                            {
                                double testfield = Convert.ToDouble(field);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("The PSiRA field should only contain numbers");
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    break;
                case 2:
                    {
                        if (field == "")
                        {
                            return false;
                        }
                    }
                    break;
                default:
                    break;
            }
            return true;
        }
        private void frmAdminPanel_Load(object sender, EventArgs e)
        {
            ClearOfficerTab();
            ReloadOfficerList();
            ClearSiteTab();
            ReloadSiteList();
            ClearPersonTab();
            ReloadPersonList();
        }

        #endregion
        
        #region Officers
        public void ReloadOfficerList()
        {
            ConstantClass.ToStringType = "AdminList";
            lstOfficers.DataSource = null;
            List<OfficerClass> thelist = new List<OfficerClass>();
            foreach (OfficerClass item in officerClass.GetOfficerData())
            {
                if (item.Active == "true")
                {
                    thelist.Add(item);
                }
            }
            lstOfficers.DataSource = thelist;
        }

        public void ClearOfficerTab()
        {
            txtOfficerPSiRA.Text = "";
            txtOfficerPSiRA.Enabled = true;
            txtOfficerName.Text = ""; 
            txtOfficerSurname.Text = "";
            txtOfficerConNum.Text = "";
            lstOfficers.SelectedIndex = -1;
            btnLogOfficer.Text = "Add New Officer";
        }

        private void btnClearOfficer_Click(object sender, EventArgs e)
        {
            ClearOfficerTab();
            btnLogOfficer.Text = "Add New Officer";
            txtOfficerPSiRA.Enabled = true;

        }

        private void btnLogOfficer_Click(object sender, EventArgs e)
        {
            bool clearFlag = false;
            if (testField(txtOfficerPSiRA.Text, 1) && testField(txtOfficerName.Text) && testField(txtOfficerSurname.Text) && testField(txtOfficerConNum.Text))
            {
                officerClass.PSiRA = txtOfficerPSiRA.Text;
                officerClass.Name = txtOfficerName.Text;
                officerClass.Surname = txtOfficerSurname.Text;
                officerClass.ContactNumber = txtOfficerConNum.Text;
                if (btnLogOfficer.Text == "Add New Officer")
                {
                    if (!officerClass.DoesOfficerExsit())
                    {
                        if (officerClass.AddOfficerToDatabase())
                        {
                            MessageBox.Show("Officer Successfully Added");
                            clearFlag = true;
                        }
                        else
                        {
                            MessageBox.Show("User could not be added");
                        }
                        ReloadOfficerList();
                    }
                    else
                    {
                        MessageBox.Show("This user allready exists");
                    }

                }
                else
                {
                    if (btnLogOfficer.Text == "Update Officer")
                    {

                        if (officerClass.UpdateOfficerToDatabase())
                        {
                            MessageBox.Show("Officer Successfully Updated");
                            btnLogOfficer.Text = "Add New Officer";
                            clearFlag = true;
                        }
                        ReloadOfficerList();

                    }
                }
            }
            else
            {
                MessageBox.Show("ensure that all fields are filled in");
            }
                

            if (clearFlag)
            {
                ClearOfficerTab();
            }
        }

        private void lstOfficers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOfficers.SelectedIndex != -1)
            {
                OfficerClass officer = (OfficerClass)lstOfficers.SelectedItem;
                txtOfficerPSiRA.Text = officer.PSiRA;
                txtOfficerPSiRA.Enabled = false;
                txtOfficerName.Text = officer.Name;
                txtOfficerSurname.Text = officer.Surname;
                txtOfficerConNum.Text = officer.ContactNumber;
                btnLogOfficer.Text = "Update Officer";
            }


        }

        private void btnRemoveOfficer_Click(object sender, EventArgs e)
        {
            bool clearFlag = false;
            if (testField(txtOfficerPSiRA.Text, 1))
            {
                officerClass.PSiRA = txtOfficerPSiRA.Text;
                officerClass.RemoveOfficer();
                clearFlag = true;
            }
            else
            {
                MessageBox.Show("Ensure that a PSiRA is entered");
            }

            if (clearFlag)
            {
                ReloadOfficerList();
                ClearOfficerTab();
            }
        }

        private void btnOfficerBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        #endregion

        #region Sites

        public void ReloadSiteList()
        {
            ConstantClass.ToStringType = "AdminList";
            lstSitesList.DataSource = null;
            List<SiteClass> thelist = new List<SiteClass>();
            foreach (SiteClass item in siteClass.GetSiteData())
            {
                if (item.Active == "true")
                {
                    thelist.Add(item);
                }
            }
            lstSitesList.DataSource = thelist;
        }

        public void ClearSiteTab()
        {
            txtSiteCallSign.Text = "";
            txtSiteCallSign.Enabled = true;
            txtSiteName.Text = "";
            txtSiteClientName.Text = "";
            txtSiteContactNumber.Text = "";
            txtEmt.Text = "";
            txtFire.Text = "";
            txtArmed.Text = "";
            txtSaps.Text = "";
            lstSitesList.SelectedIndex = -1;
            btnSiteLog.Text = "Add New Site";
        }

        private void btnSiteClear_Click(object sender, EventArgs e)
        {
            ClearSiteTab();
            btnSiteLog.Text = "Add New Site";
            txtSiteCallSign.Enabled = true;
        }

        private void btnSiteLog_Click(object sender, EventArgs e)
        {
            bool clearFlag = false;
            if (testField(txtSiteCallSign.Text) && testField(txtSiteName.Text) && testField(txtSiteClientName.Text) && testField(txtSiteContactNumber.Text))
            {
                siteClass.Callsighn = txtSiteCallSign.Text;
                siteClass.SiteName = txtSiteName.Text;
                siteClass.ClientName = txtSiteClientName.Text;
                siteClass.Emt = txtEmt.Text;
                siteClass.Fire = txtFire.Text;
                siteClass.Armed = txtArmed.Text;
                siteClass.Saps = txtSaps.Text;
                siteClass.CleintContactNr = txtSiteContactNumber.Text;
                if (btnSiteLog.Text == "Add New Site")
                {
                    if (!siteClass.DoesSiteExsit())
                    {
                        if (siteClass.AddSiteToDatabase())
                        {
                            MessageBox.Show("Site Successfully Added");
                            clearFlag = true;
                        }
                        else
                        {
                            MessageBox.Show("Site could not be added");
                        }
                        ReloadSiteList();
                    }
                    else
                    {
                        MessageBox.Show("This Site allready exists");
                    }

                }
                else
                {
                    if (btnSiteLog.Text == "Update Site")
                    {

                        if (siteClass.UpdateSiteToDatabase())
                        {
                            MessageBox.Show("Site Successfully Updated");
                            btnSiteLog.Text = "Add New Site";
                            clearFlag = true;
                        }
                        ReloadSiteList();

                    }
                }
            }
            else
            {
                MessageBox.Show("Ensure that all fields are filled in");
            }
            
            if (clearFlag)
            {
                ClearSiteTab();
            }
        }

        private void lstSitesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSitesList.SelectedIndex != -1)
            {
                SiteClass site = (SiteClass)lstSitesList.SelectedItem;
                txtSiteCallSign.Text = site.Callsighn;
                txtSiteCallSign.Enabled = false;
                txtSiteName.Text = site.SiteName;
                txtSiteClientName.Text = site.ClientName;
                txtSiteContactNumber.Text = site.CleintContactNr;
                txtEmt.Text = site.Emt;
                txtFire.Text = site.Fire;
                txtArmed.Text = site.Armed;
                txtSaps.Text = site.Saps;
                btnSiteLog.Text = "Update Site";
            }
        }

        private void btnSiteRemove_Click(object sender, EventArgs e)
        {
            bool clearFlag = false;
            if (testField(txtSiteCallSign.Text))
            {
                siteClass.Callsighn = txtSiteCallSign.Text;
                siteClass.RemoveSite();
                clearFlag = true;
            }
            else
            {
                MessageBox.Show("Ensure that a call sign is entered");
            }

            if (clearFlag)
            {
                ReloadSiteList();
                ClearSiteTab();
            }
        }

        private void btnSiteBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }


        #endregion

        #region Person

        public void ReloadPersonList()
        {
            ConstantClass.ToStringType = "AdminList";
            lstPerson.DataSource = null;
            List<PersonClass> thelist = new List<PersonClass>();
            foreach (PersonClass item in personClass.GetPersonData())
            {
                if (item.Rank != 0)
                {
                    thelist.Add(item);
                }
            }
            lstPerson.DataSource = thelist;
        }

        public void ClearPersonTab()
        {
            txtPersonPSiRA.Text = "";
            txtPersonPSiRA.Enabled = true;
            txtPersonName.Text = "";
            txtPersonSurname.Text = "";
            txtPersonUsername.Text = "";
            txtPersonPassword.Text = "";
            txtPersonConPassword.Show();
            txtPersonConPassword.Text = "";
            cbAdmin.Checked = false;
            lstPerson.SelectedIndex = -1;
            btnPersonLog.Text = "Add New Employee";
        }

        private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPerson.SelectedIndex != -1)
            {
                PersonClass person = (PersonClass)lstPerson.SelectedItem;
                txtPersonPSiRA.Text = person.PSiRA;
                txtPersonPSiRA.Enabled = false;
                txtPersonName.Text = person.Name;
                txtPersonSurname.Text = person.Surname;
                txtPersonUsername.Text = person.Username;
                txtPersonPassword.Text = person.Password;
                txtPersonConPassword.Text = "";
                btnPersonLog.Text = "Update Employee";
                if(person.Rank == 2)
                {
                    cbAdmin.Checked = true;
                }
                else
                {
                    cbAdmin.Checked = false;
                }

            }
        }

        private void btnPersonClear_Click(object sender, EventArgs e)
        {
            ClearPersonTab();
            btnPersonLog.Text = "Add New Employee";
            txtPersonPSiRA.Enabled = true;
        }

        private void btnPersonLog_Click(object sender, EventArgs e)
        {
            bool clearFlag = false;
            if (testField(txtPersonPSiRA.Text, 1) && testField(txtPersonName.Text) && testField(txtPersonSurname.Text) && testField(txtPersonUsername.Text) && testField(txtPersonPassword.Text) && testField(txtPersonConPassword.Text))
            {
                if (txtPersonPassword.Text == txtPersonConPassword.Text)
                {
                    personClass.PSiRA = txtPersonPSiRA.Text;
                    personClass.Name = txtPersonName.Text;
                    personClass.Surname = txtPersonSurname.Text;
                    personClass.Username = txtPersonUsername.Text;
                    personClass.Password = txtPersonPassword.Text;
                    if (cbAdmin.Checked)
                    {
                        personClass.Rank = 2;
                    }
                    else
                    {
                        personClass.Rank = 1;
                    }
                    if (btnPersonLog.Text == "Add New Employee")
                    {
                        if (!personClass.DoesPersonExsit())
                        {
                            if (personClass.AddPersonToDatabase())
                            {
                                MessageBox.Show("Employee Successfully Added");
                                clearFlag = true;
                            }
                            else
                            {
                                MessageBox.Show("Employee could not be added");
                            }
                            ReloadPersonList();
                        }
                        else
                        {
                            MessageBox.Show("This Employee allready exists");
                        }

                    }
                    else
                    {
                        if (btnPersonLog.Text == "Update Employee")
                        {

                            if (personClass.UpdatePersonToDatabase())
                            {
                                MessageBox.Show("Employee Successfully Updated");
                                btnPersonLog.Text = "Add New Employee";
                                clearFlag = true;
                            }
                            ReloadPersonList();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("The Password Entered doesn't match the confirm password field");
                }
            }
            else
            {
                MessageBox.Show("ensure that all fields are filled in");
            }


            if (clearFlag)
            {
                ClearPersonTab();
            }
        }

        private void btnPersonRemove_Click(object sender, EventArgs e)
        {
            bool clearFlag = false;
            if (testField(txtPersonPSiRA.Text, 1))
            {
                personClass.PSiRA = txtPersonPSiRA.Text;
                personClass.RemovePerson();
                clearFlag = true;
            }
            else
            {
                MessageBox.Show("Ensure that a PSiRA is entered");
            }

            if (clearFlag)
            {
                ReloadPersonList();
                ClearPersonTab();
            }
        }

        private void btnPersonBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }


        #endregion

        
    }
}
