using System;

namespace CurrencyConverter_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Currency EUR = new Currency(0.2255, '€', "PLN");
            Currency USD = new Currency(0.2527, '$', "PLN");

            CurrencyConverter newConverter = new CurrencyConverter();
            newConverter.Converter(EUR);
            newConverter.Converter(USD);
        }
    }
    public class Currency
    {
        public double Rate { get; set; }
        public char ExpectedCurrencySymbol { get; set; }
        public string ConvertedCurrencyName { get; set; }

        public Currency(double rate, char expectedCurrencySymbol, string convertedCurrencyName)
        {
            this.Rate = rate;
            this.ExpectedCurrencySymbol = expectedCurrencySymbol;
            this.ConvertedCurrencyName = convertedCurrencyName;
        }
    }
    public class CurrencyConverter
    {
        public void Converter(Currency currency)
        {
            Console.Write("Wprowadź kwotę do przeliczenia: ");
            double givenNumber = double.Parse(Console.ReadLine());
            double result = givenNumber * currency.Rate;
            Console.WriteLine($"{givenNumber}{currency.ConvertedCurrencyName} = {Math.Round(result, 2)}{currency.ExpectedCurrencySymbol}");
        }
    }
}
