using System;

namespace CurrencyConverter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Currency EUR = new Currency(0,2255, '€', "EUR");
            Currency USD = new Currency(0,2527, '$', "USD");

            CurrencyConverter newConverter = new CurrencyConverter();
            newConverter.Converter(EUR);
            newConverter.Converter(USD);
        }
    }
    public class Currency
    {
        public double Rate { get; set; }
        public char CurrencySymbol { get; set; }
        public string CurrencyName { get; set; }

        public Currency(double rate, char currencySymbol, string currencyName)
        {
            this.Rate = rate;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyName = currencyName;
        }
    }
    public class CurrencyConverter
    {
        public void Converter(Currency currency)
        {
            Console.Write("Wprowadź kwotę do przeliczenia: ");
            double givenNumber = double.Parse(Console.ReadLine());
            double result = givenNumber * currency.Rate;
            Console.WriteLine($"{givenNumber}{currency.CurrencyName} = {Math.Round(result, 2)}{currency.CurrencySymbol}");
        }
    }
}
