using currentlyConverter.Nbp;
using System;

namespace currentlyConverter
{
    class Calculator
    {
        public static double calculate(double amount, NbpTableRate fromCurrency, NbpTableRate toCurrency, bool round = true)
        {
            double convertedValue;

            if (fromCurrency.Code.Equals("PLN"))
            {
                convertedValue = Calculator.calculatePlnToOther(amount, fromCurrency, toCurrency);
            }
            else if(toCurrency.Code.Equals("PLN"))
            {
                convertedValue = Calculator.calculateOtherToPln(amount, fromCurrency, toCurrency);
            }
            else
            {
                convertedValue = Calculator.calculateOtherToPln(amount, fromCurrency, toCurrency);
                convertedValue = Calculator.calculatePlnToOther(convertedValue, fromCurrency, toCurrency);
            }

            if (!round)
                return convertedValue;
            else
                return Math.Floor(convertedValue * 100) / 100;
        }

        public static double calculatePlnToOther(double amount, NbpTableRate fromCurrency, NbpTableRate toCurrency)
        {
            return amount / toCurrency.Mid;
        }

        public static double calculateOtherToPln(double amount, NbpTableRate fromCurrency, NbpTableRate toCurrency)
        {
            return amount * fromCurrency.Mid;
        }
    }
}
