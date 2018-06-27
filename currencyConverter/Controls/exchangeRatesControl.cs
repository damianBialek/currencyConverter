using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using currencyConverter.Nbp;

namespace currencyConverter.Controls
{
    public partial class exchangeRatesControl : UserControl
    {
        public List<NbpTableRates> nbpRates;

        public exchangeRatesControl()
        {
            InitializeComponent();
        }

        public void renderRates()
        {
            foreach (NbpTableRate rate in this.nbpRates)
            {
                currencyRate control = new currencyRate(rate.Code, rate.Mid, rate.Currency);
                exchangeRatesPanel.Controls.Add(control);
            }
        }
    }
}
