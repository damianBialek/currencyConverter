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
    public partial class Form1 : Form
    {
        NbpData nbp;
        List<NbpTableRates> nbpRates;
        Size originalFormSize;
        bool exchangeRatesPanelVisible = false;

        public Form1()
        {
            InitializeComponent();

            this.nbp = new NbpData();
            this.nbpRates = nbp.getAvailableRates();
            this.addPlnToRates();

            this.completeComboBoxes();

            this.originalFormSize = this.Size;
        }

        public void addPlnToRates()
        {
            NbpTableRate pln = new NbpTableRate();
            pln.Code = "PLN";
            pln.Currency = "Polish zloty";
            pln.Mid = 1;

            this.nbpRates.Add(pln);
        }

        public void completeComboBoxes()
        {
            foreach (NbpTableRate rate in nbpRates)
            {
                this.fromCurrentylComboBox.Items.Add(rate);
                this.toCurrentlyComboBox.Items.Add(rate);
            }

            this.fromCurrentylComboBox.SelectedItem = this.fromCurrentylComboBox.Items[this.fromCurrentylComboBox.Items.Count - 1];
            this.toCurrentlyComboBox.SelectedItem = this.toCurrentlyComboBox.Items[0];


            this.fromCurrentylComboBox.DisplayMember = "Code";
            this.fromCurrentylComboBox.ValueMember = "Code";
            this.toCurrentlyComboBox.DisplayMember = "Code";
            this.toCurrentlyComboBox.ValueMember = "Code";
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double amount;
            if(double.TryParse(inputValueTextBox.Text, out amount))
            {
                NbpTableRate fromCurrency = this.findCurrency(((NbpTableRate)this.fromCurrentylComboBox.SelectedItem).Code);
                NbpTableRate toCurrency = this.findCurrency(((NbpTableRate)this.toCurrentlyComboBox.SelectedItem).Code);

                double convertedAmount = Calculator.calculate(amount, fromCurrency, toCurrency);

                convertedValueLabel.Text = String.Format("{0:0.00}", convertedAmount);
            }
            else
            {
                MessageBox.Show("You input bad value", "Error input value");
            }
        }

        private NbpTableRate findCurrency(string code)
        {
            NbpTableRate foundRate = null;

            foreach (NbpTableRate rate in nbpRates)
            {
                if (rate.Code.Equals(code))
                    foundRate = rate;
            }

            return foundRate;
        }

        private void openAllRatesButton_Click(object sender, EventArgs e)
        {
            if (!exchangeRatesPanelVisible)
            {
                currencyConverter.Controls.exchangeRatesControl control = new currencyConverter.Controls.exchangeRatesControl();
                control.nbpRates = this.nbpRates;
                control.renderRates();
                this.exchangeRatesPanel.Controls.Add(control);
                this.exchangeRatesPanelVisible = true;

                this.openAllRatesButton.Text = "Hide Rates";
            }
            else
            {
                this.exchangeRatesPanelVisible = false;
                this.exchangeRatesPanel.Controls.Clear();
                this.Size = this.originalFormSize;

                this.openAllRatesButton.Text = "Show Rates";
            }
        }
    }
}
