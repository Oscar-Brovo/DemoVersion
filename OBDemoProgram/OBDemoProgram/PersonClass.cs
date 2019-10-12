using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBDemoProgram
{
   public class PersonClass
    {

        #region Values
        private string pSiRA;
        private string name;
        private string surname;
        private string username;
        private string password;
        private int rank;

        private List<PersonClass> loginList;
        #endregion

        #region constructor
        public PersonClass() { }

        public PersonClass(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public PersonClass(string pSiRA, string name, string surname)
        {
            this.pSiRA = pSiRA;
            this.name = name;
            this.surname = surname;
        }

        public PersonClass(string pSiRA, string name, string surname, string username, string password, int rank)
        {
            this.PSiRA = pSiRA;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Rank = rank;
        }
        #endregion

        #region properties
        public string PSiRA { get => pSiRA; set => pSiRA = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Rank { get => rank; set => rank = value; }

        #endregion

        #region Override 
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
            return string.Format(pSiRA+": "+name+" "+surname );
        }
        #endregion


        #region Method
        public void PopulatingList()
        {
            FileHandler fh = new FileHandler("Userfile.csv");
            List<string> theList = fh.ReadDataFromTXT();

            loginList = new List<PersonClass>();

            foreach (string data in theList)
            {
                string[] test = data.Split(',');
                loginList.Add(new PersonClass(test[0], test[1], test[2], test[3], test[4], int.Parse(test[5])));
                // pSiRA , Name , Surename , Username , password , rank
            }


        }
        public bool LoginMethod()
        {
            for (int i = 0; i < loginList.Count; i++)
            {
                if ((loginList[i].Username.Equals(username)) && (loginList[i].Password.Equals(password)) && (loginList[i].Rank != 0))
                {
                    name = loginList[i].Name;
                    surname = loginList[i].Surname;
                    rank = loginList[i].Rank;
                    pSiRA = loginList[i].PSiRA;
                    return true;
                }

            }
            return false;
        }

        #endregion
    }
}
