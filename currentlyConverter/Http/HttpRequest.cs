using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;

namespace currentlyConverter.Http
{
    class HttpRequest
    {
        public string httpRequest(string url)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/xml");

            return client.GetStringAsync(url).Result;
        }
    }
}
