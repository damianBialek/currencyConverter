using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using currencyConverter.Http;

namespace currencyConverter.Nbp
{
    class NbpData
    {
        string url = "http://api.nbp.pl/api/exchangerates/rates/";
        string urlTables = "http://api.nbp.pl/api/exchangerates/tables/";
        string table = "a";

        NbpTables nbpTables;

        public List<NbpTableRates> getAvailableRates()
        {
            this.downloadFullTable();

            return this.nbpTables.Tables[0].Rates;
        }

        public NbpTables downloadFullTable()
        {
            if (this.nbpTables != null)
                return this.nbpTables;

            string url = this.buildUrl();

            Stream responseFromServer = HttpRequest.httpRequest(url);

            XmlSerializer xml = new XmlSerializer(typeof(NbpTables));

            this.nbpTables = (NbpTables)xml.Deserialize(responseFromServer);

            return this.nbpTables;
        }

        string buildUrl(string type = "table")
        {
            if (type.Equals("table"))
                return this.urlTables + this.table;
            else
                return this.url + this.table;
        }
    }
}
