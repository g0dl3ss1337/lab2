using System;

namespace Task2
{
    class Converter
    {
        private const double UsdRate = 36.65;
        private const double EurRate = 39.28;
        private const double PlnRate = 8.56;

        public double ConvertToUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount * UsdRate;
                case "eur":
                    return amount * EurRate;
                case "pln":
                    return amount * PlnRate;
                default:
                    throw new ArgumentException("Непiдтримувана валюта");
            }
        }

        public double ConvertFromUah(double amount, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return amount / UsdRate;
                case "eur":
                    return amount / EurRate;
                case "pln":
                    return amount / PlnRate;
                default:
                    throw new ArgumentException("Непiдтримувана валюта");
            }
        }
    }
}
