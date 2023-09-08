using System;
using System.Text;
using Task1;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Address address_data = new Address();

            address_data.Index = "02000";
            address_data.Country = "Україна";
            address_data.City = "Київ";
            address_data.Street = "вул. Хрещатик";
            address_data.House = "20";
            address_data.Apartment = "37";

            address_data.Print();
        }
    }
}
