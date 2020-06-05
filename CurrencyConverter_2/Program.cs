using System;
using System.Collections.Generic;

namespace CurrencyConverter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Currency> currencies = new List<Currency>();

            currencies.Add(new Currency(0.2255, '€', "EUR"));
            currencies.Add(new Currency(0.2527, '$', "USD"));
            currencies.Add(new Currency(0.2019, '£', "GBP"));
            currencies.Add(new Currency(17.5131, '₽', "RUB"));

            Console.WriteLine("Wybierz walutę, na którą zostanie przeliczona kwota w PLN: ");

            int currencyIndex = 1;

            foreach (Currency currency in currencies)
            {
                Console.WriteLine(currencyIndex + "." + currency.Name);

                currencyIndex++;
            }

            Console.Write("Podaj cyfre odpowiadającą walucie: ");

            int number = int.Parse(Console.ReadLine());

            CurrencyConverter converter = new CurrencyConverter();

            converter.ConvertTo(currencies[number - 1]);
        }
    }

    public class Currency
    {
        public double Rate { get; set; }
        public char Symbol { get; set; }
        public string Name { get; set; }

        public Currency(double rate, char symbol, string name)
        {
            Rate = rate;
            Symbol = symbol;
            Name = name;
        }
    }

    public class CurrencyConverter
    {
        public void ConvertTo(Currency currency)
        {
            Console.Write("Wprowadź kwotę do przeliczenia: ");

            double amount = double.Parse(Console.ReadLine());
            double convertedAmount = amount * currency.Rate;

            Console.WriteLine($"{amount}PLN = {Math.Round(convertedAmount, 2)}{currency.Symbol}");
        }
    }
}
