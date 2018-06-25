using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyConverter
{
    public partial class currencyRate : UserControl
    {
        string code;
        double rate;

        public currencyRate(string code, double rate)
        {
            InitializeComponent();

            this.code = code;
            this.rate = rate;

            this.currencyCodeLabel.Text = this.code;
            this.currencyRateLabel.Text = this.rate.ToString();
        }
    }
}
