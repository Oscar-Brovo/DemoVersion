using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB_0._01
{
   public class OcurranceBookClass
    {
        private string robDate; //Primary key.
        private string rob;
        private int ob;
        private int shifts;
        private string site;
        private string occurence;
        private string notes;
        private string officer;
        private DateTime dateAndTime;
        public OcurranceBookClass() { }
        public OcurranceBookClass(string robDate, string rob, int ob, int shifts, string site, string occurence, string notes, string officer, DateTime dateAndTime)
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

        public string RobDate { get => robDate; set => robDate = value; }
        public string Rob { get => rob; set => rob = value; }
        public int Ob { get => ob; set => ob = value; }
        public int Shifts { get => shifts; set => shifts = value; }
        public string Site { get => site; set => site = value; }
        public string Occurence { get => occurence; set => occurence = value; }
        public string Notes { get => notes; set => notes = value; }
        public string Officer { get => officer; set => officer = value; }
        public DateTime DateAndTime { get => dateAndTime; set => dateAndTime = value; }
    }
}
