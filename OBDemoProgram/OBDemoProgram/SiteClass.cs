using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBDemoProgram
{
   public class SiteClass
    {
        private string callsighn;
        private string siteName;
        private string clientName;
        private string cleintContactNr;
        private string active;

        private List<SiteClass> siteList;
        public SiteClass() { }
        public SiteClass(string callsighn, string siteName, string clientName, string cleintContactNr, string active)
        {
            this.Callsighn = callsighn;
            this.SiteName = siteName;
            this.ClientName = clientName;
            this.CleintContactNr = cleintContactNr;
            this.Active = active;
        }

        public string Callsighn { get => callsighn; set => callsighn = value; }
        public string SiteName { get => siteName; set => siteName = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string CleintContactNr { get => cleintContactNr; set => cleintContactNr = value; }
        public string Active { get => active; set => active = value; }

        public override string ToString()
        {
            return string.Format(callsighn + ": " + siteName);
        }

        #region Methods
        
        public List<SiteClass> GetSiteData()
        {
            siteList = new List<SiteClass>();
            FileHandler fh = new FileHandler("Sitefile.csv");
            List<string> theList = fh.ReadDataFromTXT();
            foreach (string data in theList)
            {
                if (data != "")
                {
                    string[] line = data.Split(',');
                    siteList.Add(new SiteClass(line[0], line[1], line[2], line[3], line[4]));
                   
                }
            }

            return siteList;
        }

        public bool DoesSiteExsit()
        {
            int index = 0;
            while (index < siteList.Count)
            {
                if (siteList[index].Callsighn.Equals(callsighn) && siteList[index].active == "true")
                {
                    return true;
                }
                index++;
            }
            return false;
        }

        public bool AddSiteToDatabase()
        {
            try
            {
                bool addSite = false;
                FileHandler fh = new FileHandler("Sitefile.csv");
                for (int i = 0; i < siteList.Count; i++)
                {
                    if (siteList[i].Callsighn.Equals(callsighn))
                    {
                        siteList[i].SiteName = siteName;
                        siteList[i].ClientName = clientName;
                        siteList[i].CleintContactNr = cleintContactNr;
                        siteList[i].active = "true";
                        addSite = true;
                        List<string> theList = new List<string>();
                        foreach (SiteClass item in siteList)
                        {
                            theList.Add(item.Callsighn + "," + item.SiteName + "," + item.ClientName + "," + item.CleintContactNr + "," + item.active);
                        }

                        fh.RewriteDataToTXT(theList);
                        break;
                    }
                }
                if (!addSite)
                {
                    List<string> thelist = new List<string>() { callsighn + "," + siteName + "," + clientName + "," + cleintContactNr + "," + "true" };
                    fh.WriteDataToTXT(thelist);
                }


            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool UpdateSiteToDatabase()
        {
            try
            {
                FileHandler fh = new FileHandler("Sitefile.csv");
                for (int i = 0; i < siteList.Count; i++)
                {
                    if (siteList[i].Callsighn.Equals(callsighn))
                    {
                        siteList[i].SiteName = siteName;
                        siteList[i].ClientName = clientName;
                        siteList[i].CleintContactNr = cleintContactNr;
                        siteList[i].active = "true";
                        break;
                    }
                }

                List<string> theList = new List<string>();
                foreach (SiteClass item in siteList)
                {
                    theList.Add(item.Callsighn + "," + item.SiteName + "," + item.ClientName + "," + item.CleintContactNr + "," + item.active);
                }

                fh.RewriteDataToTXT(theList);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool RemoveSite()
        {
            try
            {
                FileHandler fh = new FileHandler("Sitefile.csv");
                int index = 0;
                while (index < siteList.Count)
                {
                    if (siteList[index].Callsighn.Equals(callsighn))
                    {
                        break;
                    }
                    index++;
                }
                siteList[index].active = "false";

                List<string> theList = new List<string>();
                foreach (SiteClass item in siteList)
                {
                    theList.Add(item.Callsighn + "," + item.SiteName + "," + item.ClientName + "," + item.CleintContactNr + "," + item.active);
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
