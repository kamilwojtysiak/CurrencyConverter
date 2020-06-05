<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace CurrencyConverter_2
=======
﻿namespace CurrencyConverter_2
>>>>>>> 27bd8de2deab9322e4e7fb2c6945d924455af0fd
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
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
=======
            Console.WriteLine("Wybierz walutę, na którą zostanie przeliczona kwota w PLN: ");
            Console.WriteLine("1.EUR \n2.USD \n3.GBP");
            Console.Write("Podaj liczbe przypisaną walucie: ");

            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                Currency eur = new Currency(0.2255, '€', "PLN");

                CurrencyConverter converter = new CurrencyConverter();
                converter.ConvertTo(eur);
            }
            else if (number == 2)
            {
                Currency usd = new Currency(0.2527, '$', "PLN");

                CurrencyConverter converter = new CurrencyConverter();
                converter.ConvertTo(usd);
            }
            else if (number == 3)
            {
                Currency gbp = new Currency(0.2019, '£', "PLN");

                CurrencyConverter converter = new CurrencyConverter();
                converter.ConvertTo(gbp);
            }
            else
            {
                Console.WriteLine("Błędnie wprowadzona liczba.");
            }
>>>>>>> 27bd8de2deab9322e4e7fb2c6945d924455af0fd
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

<<<<<<< HEAD
            Console.WriteLine($"{amount}PLN = {Math.Round(convertedAmount, 2)}{currency.Symbol}");
=======
            Console.WriteLine($"{amount}{currency.Name} = {Math.Round(convertedAmount, 2)}{currency.Symbol}");
>>>>>>> 27bd8de2deab9322e4e7fb2c6945d924455af0fd
        }
    }
}
