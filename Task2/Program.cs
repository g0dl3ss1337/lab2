using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter();

            while (true)
            {
                Console.WriteLine("1. usd / eur / pln -> uah");
                Console.WriteLine("2. uah -> usd / eur / pln");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Введiть суму: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введiть валюту ( usd / eur / pln): ");
                    string currency = Console.ReadLine();

                    double result = converter.ConvertToUah(amount, currency);
                    Console.WriteLine($"{amount} {currency} = {result} uah");
                }
                else if (choice == "2")
                {
                    Console.Write("Введiть суму: ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введiть валюту ( usd / eur / pln ): ");
                    string currency = Console.ReadLine();

                    double result = converter.ConvertFromUah(amount, currency);
                    Console.WriteLine($"{amount} гривень = {result} {currency}");
                }
                else
                {
                    Console.WriteLine("Неправильний вибiр операцiї. Спробуйте ще раз.");
                }
            }
        }
    }
}
