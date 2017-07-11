using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("MAC", "Apple");
            stocks.Add("SAM", "Samsung");
            stocks.Add("ROV", "Rover");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 150, price: 20.15));
            purchases.Add((ticker: "CAT", shares: 32, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 32, price: 13.75));
            purchases.Add((ticker: "MAC", shares: 100, price: 19.02));
            purchases.Add((ticker: "MAC", shares: 100, price: 16.00));
            purchases.Add((ticker: "SAM", shares: 120, price: 11.25));
            purchases.Add((ticker: "SAM", shares: 120, price: 15.75));
            purchases.Add((ticker: "ROV", shares: 30, price: 10.05));
            purchases.Add((ticker: "ROV", shares: 12, price: 11.25));

        //     Define a new Dictionary to hold the aggregated purchase information.
        //     - The key should be a string that is the full company name.
        //     - The value will be the valuation of each stock (price*amount)

        //     {
        //         "General Electric": 35900,
        //         "AAPL": 8445,
        //         ...
        //     }
        // */
            Dictionary<string, double> totalStocks = new Dictionary<string, double>();
            // Iterate over the purchases and 
            // Does the company name key already exist in the report dictionary?
            // If it does, update the total valuation
            // If not, add the new key and set its value
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (totalStocks.ContainsKey(stocks[purchase.ticker]))
                {
                    totalStocks.Add(shares, price);
                }
                else
                { (!totalStocks.ContainsKey(purchase.ticker))
                    totalStocks.Add();
                }


            }
        }
    }
}

