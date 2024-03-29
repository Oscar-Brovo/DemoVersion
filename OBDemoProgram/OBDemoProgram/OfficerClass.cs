﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBDemoProgram
{
    public class OfficerClass
    {
        #region Values
        private string pSiRA;
        private string name;
        private string surname;
        private string contactNumber;
        private string site;
        private string active;


        private List<OfficerClass> officerList;
        #endregion

        #region Constructors
        public OfficerClass() { }
        public OfficerClass(string pSiRA, string name, string surname, string contactNumber, string site, string active)
        {
            this.PSiRA = pSiRA;
            this.Name = name;
            this.Surname = surname;
            this.ContactNumber = contactNumber;
            this.Site = site;
            this.Active = active;

        }

        #endregion

        #region Properties
        public string PSiRA { get => pSiRA; set => pSiRA = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Site { get => site; set => site = value; }
        public string Active { get => active; set => active = value; }
        #endregion

        #region Overrides
        public override string ToString()
        {
            return GetTypeToString();
        }
        public string GetTypeToString()
        {
            if (ConstantClass.ToStringType == "AdminList")
            {
                return string.Format(pSiRA + ": " + name + " " + surname);
            }
            if (ConstantClass.ToStringType == "OBCombo")
            {
                return string.Format(name +" "+surname);
            }
            return string.Format(name + " " + surname);
        }
        #endregion

        #region Methods


        public List<OfficerClass> GetOfficerData()
        {
            officerList = new List<OfficerClass>();
            FileHandler fh = new FileHandler("Officerfile.csv");
            List<string> theList = fh.ReadDataFromTXT();
            foreach (string data in theList)
            {
                if (data != "")
                {
                    string[] line = data.Split(',');
                    officerList.Add(new OfficerClass(line[0], line[1], line[2], line[3], line[4], line[5]));
                    // pSiRA , Name , Surename, contactNumber, active
                }
            }

            return officerList;
        }

        public List<OfficerClass> getActiveOfficers()
        {
            GetOfficerData();
            List<OfficerClass> thelist = new List<OfficerClass>();
            foreach (OfficerClass item in officerList)
            {
                if (item.Active == "true")
                {
                    thelist.Add(item);
                }
            }
            return thelist;
        }

        public bool DoesOfficerExsit()
        {
            int index = 0;
            while (index < officerList.Count)
            {
                if (officerList[index].PSiRA.Equals(pSiRA) && officerList[index].active == "true")
                {
                    return true;
                }
                index++;
            }
            return false;
        }

        public bool AddOfficerToDatabase()
        {
            try
            {
                bool addUser = false;
                FileHandler fh = new FileHandler("Officerfile.csv");
                for (int i = 0; i < officerList.Count; i++)
                {
                    if (officerList[i].PSiRA.Equals(pSiRA))
                    {
                        officerList[i].Name = name;
                        officerList[i].Surname = surname;
                        officerList[i].contactNumber = contactNumber;
                        officerList[i].Site = site;
                        officerList[i].active = "true";
                        addUser = true;
                        List<string> theList = new List<string>();
                        foreach (OfficerClass item in officerList)
                        {
                            theList.Add(item.PSiRA + "," + item.Name + "," + item.Surname + "," + item.ContactNumber + "," + item.site + "," + item.active);
                        }

                        fh.RewriteDataToTXT(theList);
                        break;
                    }
                }
                if (!addUser)
                {
                    List<string> thelist = new List<string>() { pSiRA + "," + name + "," + surname + "," + contactNumber + "," + site + "," + "true" };
                    fh.WriteDataToTXT(thelist);
                }
                
                
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool UpdateOfficerToDatabase()
        {
            try
            {
                FileHandler fh = new FileHandler("Officerfile.csv");
                for (int i = 0; i < officerList.Count; i++)
                {
                    if (officerList[i].PSiRA.Equals(pSiRA))
                    {
                        officerList[i].Name = name;
                        officerList[i].Surname = surname;
                        officerList[i].contactNumber = contactNumber;
                        officerList[i].Site = site;
                        officerList[i].active = "true";
                        break;
                    }
                }

                List<string> theList = new List<string>();
                foreach (OfficerClass item in officerList)
                {
                    theList.Add(item.PSiRA + "," + item.Name + "," + item.Surname + "," + item.ContactNumber + "," + item.Site + "," + item.active);
                }

                fh.RewriteDataToTXT(theList);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        
        public bool RemoveOfficer()
        {
            try
            {
                FileHandler fh = new FileHandler("Officerfile.csv");
                int index = 0;
                while (index < officerList.Count)
                {
                    if (officerList[index].PSiRA.Equals(pSiRA))
                    {
                        break;
                    }
                    index++;
                }
                officerList[index].active = "false";

                List<string> theList = new List<string>();
                foreach (OfficerClass item in officerList)
                {
                    theList.Add(item.PSiRA + "," + item.Name + "," + item.Surname + "," + item.ContactNumber + "," + item.Site + "," + item.active);
                }

                fh.RewriteDataToTXT(theList);
            }
            catch (Exception)
            {

                return false;
            }

            return true;
        }
        #endregion
    }
}
