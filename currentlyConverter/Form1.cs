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
using currentlyConverter.Nbp;

namespace currentlyConverter
{
    public partial class Form1 : Form
    {
        NbpData nbp;
        List<NbpTableRates> nbpRates;

        public Form1()
        {
            InitializeComponent();

            this.nbp = new NbpData();
            this.nbpRates = nbp.getAvailableRates();
            this.addPlnToRates();

            this.completeComboBoxes();
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
            exchangeRates form = new exchangeRates();
            form.nbpRates = this.nbpRates;
            form.renderRates();
            form.Show(this);

            form.FormClosed += new FormClosedEventHandler(this.activateButton);

            this.openAllRatesButton.Visible = false;
        }

        private void activateButton(object sender, FormClosedEventArgs e)
        {
            this.openAllRatesButton.Visible = true;
        }
    }
}
