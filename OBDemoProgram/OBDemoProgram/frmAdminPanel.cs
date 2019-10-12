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
        public frmAdminPanel()
        {
            InitializeComponent();
           // officerClass.PopulatingList();
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
        }

        #endregion


        #region Officers
        public void ReloadOfficerList()
        {
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
            // frmMenu menu = 
            Environment.Exit(0);
        }

        #endregion

        #region Sites
       
        #endregion

        private void btnSiteClear_Click(object sender, EventArgs e)
        {

        }
    }
}
