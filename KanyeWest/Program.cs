using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeWest
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                KanyeQuoteGenerator.KanyeQuote();
                RonQuoteGenerator.RonQuote();
            }
        }
    }
}