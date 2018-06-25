using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using currencyConverter.Nbp;

namespace currencyConverter
{
    public partial class exchangeRates : Form
    {
        public List<NbpTableRates> nbpRates;

        public exchangeRates()
        {
            InitializeComponent();

            this.Dock = DockStyle.Left;
        }

        public void renderRates()
        {
            foreach (NbpTableRate rate in this.nbpRates)
            {
                currencyRate control = new currencyRate(rate.Code, rate.Mid);
                exchangeRatesPanel.Controls.Add(control);
            }
        }
    }
}
