using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBDemoProgram
{
   public class SiteClass 
    {
        private string callsighn;
        private string siteName;
        private string clientName;
        private string cleintContactNr;
        private string emt;
        private string fire;
        private string armed;
        private string saps;
        private string active;

        private List<SiteClass> siteList;
        public SiteClass() { }
        public SiteClass(string callsighn, string siteName, string clientName, string cleintContactNr, string emt, string fire, string armed, string saps, string active)
        {
            this.Callsighn = callsighn;
            this.SiteName = siteName;
            this.ClientName = clientName;
            this.CleintContactNr = cleintContactNr;
            this.Emt = emt;
            this.Fire = fire;
            this.Armed = armed;
            this.Saps = saps;
            this.Active = active;
        }

        public string Callsighn { get => callsighn; set => callsighn = value; }
        public string SiteName { get => siteName; set => siteName = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string CleintContactNr { get => cleintContactNr; set => cleintContactNr = value; }
        public string Emt { get => emt; set => emt = value; }
        public string Fire { get => fire; set => fire =  value; }
        public string Armed { get => armed; set => armed = value; }
        public string Saps { get => saps; set => saps = value; }
        public string Active { get => active; set => active = value; }

        
        public override string ToString()
        {
            return GetTypeToString();
        }
        
        public string GetTypeToString()
        {
            if(ConstantClass.ToStringType == "AdminList")
            {
                return string.Format(callsighn + ":" + siteName);
            }
            if(ConstantClass.ToStringType == "OBCombo")
            {
                return siteName;
            }
            if (ConstantClass.ToStringType == "AdminCombo")
            {
                return callsighn;
            }

            return "Error";
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
                    siteList.Add(new SiteClass(line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8]));
                   
                }
            }

            return siteList;
        }

        public List<SiteClass> GetActiveSites()
        {
            GetSiteData();
            List<SiteClass> siteActiveList = new List<SiteClass>();
            foreach (SiteClass item in siteList)
            {
                if (item.Active=="true")
                {
                    siteActiveList.Add(item);
                }
            }
            return siteActiveList;
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
                        siteList[i].Emt = emt;
                        siteList[i].Fire = fire;
                        siteList[i].Armed = armed;
                        siteList[i].Saps = saps;
                        siteList[i].active = "true";
                        addSite = true;
                        List<string> theList = new List<string>();
                        foreach (SiteClass item in siteList)
                        {
                            theList.Add(item.Callsighn + "," + item.SiteName + "," + item.ClientName + "," + item.CleintContactNr + "," + item.Emt + "," + item.Fire + "," + item.Armed + "," + item.Saps + "," + item.active);
                        }

                        fh.RewriteDataToTXT(theList);
                        break;
                    }
                }
                if (!addSite)
                {
                    List<string> thelist = new List<string>() { callsighn + "," + siteName + "," + clientName + "," + cleintContactNr + "," + emt + "," + fire + "," + fire + "," + saps + "," + "true" };
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
                        siteList[i].Emt = emt;
                        siteList[i].Fire = fire;
                        siteList[i].Armed = armed;
                        siteList[i].Saps = saps;
                        siteList[i].active = "true";
                        break;
                    }
                }

                List<string> theList = new List<string>();
                foreach (SiteClass item in siteList)
                {
                    theList.Add(item.Callsighn + "," + item.SiteName + "," + item.ClientName + "," + item.CleintContactNr + "," + item.Emt + "," + item.fire + "," + item.Armed + "," + item.Saps + "," + item.active);
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
                    theList.Add(item.Callsighn + "," + item.SiteName + "," + item.ClientName + "," + item.CleintContactNr + "," + item.Emt + "," + item.fire + "," + item.Armed + "," + item.Saps + "," + item.active);
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
