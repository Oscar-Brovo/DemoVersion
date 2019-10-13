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
        private List<PersonClass> personList;
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

        public List<PersonClass> GetPersonData()
        {
            personList = new List<PersonClass>();
            FileHandler fh = new FileHandler("Userfile.csv");
            List<string> theList = fh.ReadDataFromTXT();
            foreach (string data in theList)
            {
                if (data != "")
                {
                    string[] line = data.Split(',');
                    personList.Add(new PersonClass(line[0], line[1], line[2], line[3], line[4], int.Parse(line[5])));
                    // pSiRA , Name , Surename, username, password, rank
                }
            }

            return personList;
        }

        public bool DoesPersonExsit()
        {
            int index = 0;
            while (index < personList.Count)
            {
                if (personList[index].PSiRA.Equals(pSiRA) && personList[index].Rank != 0 )
                {
                    return true;
                }
                index++;
            }
            return false;
        }

        public bool AddPersonToDatabase()
        {
            try
            {
                bool addUser = false;
                FileHandler fh = new FileHandler("Userfile.csv");
                for (int i = 0; i < personList.Count; i++)
                {
                    if (personList[i].PSiRA.Equals(pSiRA))
                    {
                        personList[i].Name = name;
                        personList[i].Surname = surname;
                        personList[i].Username = username;
                        personList[i].Password = password;
                        personList[i].Rank = rank;
                        addUser = true;
                        List<string> theList = new List<string>();
                        foreach (PersonClass item in personList)
                        {
                            theList.Add(item.PSiRA + "," + item.Name + "," + item.Surname + "," + item.Username + "," + item.Password + "," + item.Rank);
                        }

                        fh.RewriteDataToTXT(theList);
                        break;
                    }
                }
                if (!addUser)
                {
                    List<string> thelist = new List<string>() { pSiRA + "," + name + "," + surname + "," + username + "," + password + "," + rank };
                    fh.WriteDataToTXT(thelist);
                }


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdatePersonToDatabase()
        {
            try
            {
                FileHandler fh = new FileHandler("Userfile.csv");
                for (int i = 0; i < personList.Count; i++)
                {
                    if (personList[i].PSiRA.Equals(pSiRA))
                    {
                        personList[i].Name = name;
                        personList[i].Surname = surname;
                        personList[i].Username = username;
                        personList[i].Password = password;
                        personList[i].Rank = rank;
                        break;
                    }
                }

                List<string> theList = new List<string>();
                foreach (PersonClass item in personList)
                {
                    theList.Add(item.PSiRA + "," + item.Name + "," + item.Surname + "," + item.Username + "," + item.Password + "," + item.Rank);
                }

                fh.RewriteDataToTXT(theList);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RemovePerson()
        {
            try
            {
                FileHandler fh = new FileHandler("Userfile.csv");
                int index = 0;
                while (index < personList.Count)
                {
                    if (personList[index].PSiRA.Equals(pSiRA))
                    {
                        break;
                    }
                    index++;
                }
                personList[index].Rank = 0;

                List<string> theList = new List<string>();
                foreach (PersonClass item in personList)
                {
                    theList.Add(item.PSiRA + "," + item.Name + "," + item.Surname + "," + item.Username + "," + item.Password + "," + item.Rank);
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
