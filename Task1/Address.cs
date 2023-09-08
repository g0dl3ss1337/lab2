using System;

namespace Task1
{
    public class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            get { return index; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    index = value;
                }
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    country = value;
                }
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    city = value;
                }
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    street = value;
                }
            }
        }

        public string House
        {
            get { return house; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    house = value;
                }
            }
        }

        public string Apartment
        {
            get { return apartment; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    apartment = value;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"Index: {index}\n" +
                            $"Country: {country}\n" +
                            $"City: {city}\n" +
                            $"Street: {street}\n" +
                            $"House: {house}\n" +
                            $"Apartment: {apartment}\n");
        }
    }
}
