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

        public currencyRate(string code, double rate, string name)
        {
            InitializeComponent();

            this.code = code;
            this.rate = rate;

            this.currencyCodeLabel.Text = this.code;
            this.currencyRateLabel.Text = this.rate.ToString();
            this.toolTip1.SetToolTip(this.currencyCodeLabel, name);
            this.toolTip1.InitialDelay = 500;
        }
    }
}
