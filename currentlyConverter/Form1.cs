using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using currentlyConverter.Http;
using System.IO;

namespace currentlyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string test = new HttpRequest().httpRequest("http://api.nbp.pl/api/exchangerates/rates/a/chf/");
        }
    }
}
