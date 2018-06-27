using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using System.Windows.Forms;

namespace currencyConverter.Http
{
    class HttpRequest
    {
        public static Stream httpRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Accept", "application/xml");
                try
                {
                    Task<Stream> request = client.GetStreamAsync(url);
                    request.Wait();

                    return request.Result;
                }
                catch (Exception)
                {
                    MessageBox.Show("You don't have access to Internet", "Error!");
                    System.Environment.Exit(0);
                    return new MemoryStream();
                }
            }
        }

    }
}
