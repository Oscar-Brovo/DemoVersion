using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB_0._01
{
   public class PersonClass
    {
        private int iD;
        private string name;
        private string surname;
        private string username;
        private string password;
        private int rank;

        private List<PersonClass> loginList;
        public PersonClass() { }

        public PersonClass(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public PersonClass(int iD, string name, string surname)
        {
            this.iD = iD;
            this.name = name;
            this.surname = surname;
        }

        public PersonClass(int iD, string name, string surname, string username, string password, int rank)
        {
            this.ID = iD;
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.Rank = rank;
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Rank { get => rank; set => rank = value; }

        public void PopulatingList() 
        {
            FileHandler fh = new FileHandler("Userfile.csv");
            List<string> theList = fh.ReadDataFromTXT();

            loginList = new List<PersonClass>();

            foreach (string data in theList)
            {
                string[] test = data.Split(',');
                loginList.Add(new PersonClass(int.Parse(test[0]),test[1],test[2],test[3],test[4], int.Parse(test[5])));
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
                    iD = loginList[i].ID;
                    return true;
                }   

            }
            return false;
        }
    }
}
