namespace CurrencyConverter_2
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine($"{amount}{currency.Name} = {Math.Round(convertedAmount, 2)}{currency.Symbol}");
        }
    }
}
