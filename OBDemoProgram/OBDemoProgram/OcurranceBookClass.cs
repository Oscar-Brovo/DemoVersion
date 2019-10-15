using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBDemoProgram
{
   public class OcurranceBookClass
    {
        #region Values
        private string robDate; //Primary key.
        private int rob;
        private int ob;
        private string shifts;
        private string site;
        private string occurence;
        private string notes; 
        private int  officer;
        private string dateAndTime;

        public List<OcurranceBookClass> obList = new List<OcurranceBookClass>();
        #endregion

        #region Constructors 
        public OcurranceBookClass() { }
        public OcurranceBookClass(string robDate, int rob, int ob, string shifts, string site, string occurence, string notes, int officer, string dateAndTime)
        {
            this.RobDate = robDate;
            this.Rob = rob;
            this.Ob = ob;
            this.Shifts = shifts;
            this.Site = site;
            this.Occurence = occurence;
            this.Notes = notes;
            this.Officer = officer;
            this.DateAndTime = dateAndTime;
        }

        #endregion
        
        #region Properties
        public string RobDate { get => robDate; set => robDate = value; }
        public int Rob { get => rob; set => rob = value; }
        public int Ob { get => ob; set => ob = value; }
        public string Shifts { get => shifts; set => shifts = value; }
        public string Site { get => site; set => site = value; }
        public string Occurence { get => occurence; set => occurence = value; }
        public string Notes { get => notes; set => notes = value; }
        public int Officer { get => officer; set => officer = value; }
        public string DateAndTime { get => dateAndTime; set => dateAndTime = value; }
        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format(rob + "  - " + dateAndTime.Split('#')[0] + " " + dateAndTime.Split('#')[1] + " : " + occurence);
        }
        #endregion

        #region Methods

        public void PopulateOBList()
        {
            obList = new List<OcurranceBookClass>();
            FileHandler fh = new FileHandler("OBList.csv");
            List<string> theList = fh.ReadDataFromTXT();
            if (theList!=null)
            {
                foreach (string data in theList)
                {
                    if (data != "")
                    {
                        string[] line = data.Split(',');
                        obList.Add(new OcurranceBookClass(line[0], int.Parse(line[1]), int.Parse(line[2]), line[3], line[4], line[5], line[6], int.Parse(line[7]), line[8]));
                        // robdate , rob , ob , shift , site , occurence , notes , officer , date time
                    }
                }
            }
            
        }

        public string GetNewReturnOBNumber()
        {
            try
            {
                return (obList[obList.Count - 1].Rob + 1).ToString();
            }
            catch (Exception)
            {

                return "1";
            }
        }

        public bool DoesOBEntryExist()
        {
            bool flag = false;
            if (obList != null)
            {
                for (int i = 0; i < obList.Count; i++)
                {
                    if (obList[i].RobDate.Equals(robDate))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool RecordEntry()
        {
            FileHandler fh = new FileHandler("OBList.csv");
            List<string> theList = new List<string>();
            theList.Add(ObjectToString());
            if (fh.WriteDataToTXT(theList))
            {
                return true;
            }
            return false;
        }

        public string ObjectToString()
        {
            return robDate + "," + rob + "," + ob + "," + shifts + "," + site + "," + occurence + "," + notes.Replace(',', '@').Replace(Environment.NewLine, "&") + "," + officer + "," + dateAndTime;
        }
        #endregion
    }
}
