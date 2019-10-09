using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OB_0._01
{
   public class SiteClass
    {
        private string callsighn;
        private string siteName;
        private string clientName;
        private string cleintContactNr;
        public SiteClass() { }
        public SiteClass(string callsighn, string siteName, string clientName, string cleintContactNr)
        {
            this.Callsighn = callsighn;
            this.SiteName = siteName;
            this.ClientName = clientName;
            this.CleintContactNr = cleintContactNr;
        }

        public string Callsighn { get => callsighn; set => callsighn = value; }
        public string SiteName { get => siteName; set => siteName = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string CleintContactNr { get => cleintContactNr; set => cleintContactNr = value; }
    }
}
