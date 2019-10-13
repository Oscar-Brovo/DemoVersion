using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBDemoProgram
{
   public class OcurranceBookClass
    {
        #region Values
        private string robDate; //Primary key.
        private string rob;
        private int ob;
        private int shifts;
        private string site;
        private string occurence;
        private string notes; 
        private string  officer;
        private string dateAndTime;

        private List<OcurranceBookClass> obList = new List<OcurranceBookClass>();
        #endregion

        #region Constructors 
        public OcurranceBookClass() { }
        public OcurranceBookClass(string robDate, string rob, int ob, int shifts, string site, string occurence, string notes, string officer, string dateAndTime)
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
        public string Rob { get => rob; set => rob = value; }
        public int Ob { get => ob; set => ob = value; }
        public int Shifts { get => shifts; set => shifts = value; }
        public string Site { get => site; set => site = value; }
        public string Occurence { get => occurence; set => occurence = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Officer { get => officer; set => officer = value; }
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
            return base.ToString();
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
                        obList.Add(new OcurranceBookClass(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), line[4], line[5], line[6], line[7], line[8]));
                        
                    }
                }
            }
            
        }

        public string GetNewReturnOBNumber()
        {
            if (obList == null)
            {
                return "1";
            }
            else
            {
                return (int.Parse(obList[obList.Count - 1].Rob)+1).ToString();
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

        #endregion
    }
}
