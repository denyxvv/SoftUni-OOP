using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Smartphone : ISmartphone, IStationaryPhone
    {
        public void Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
                Console.WriteLine("Invalid number!");
            else
                Console.WriteLine($"Calling... {number}");
        }

        public void BrowseURL(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
                Console.WriteLine($"Browsing: {url}!");
        }
    }
}
