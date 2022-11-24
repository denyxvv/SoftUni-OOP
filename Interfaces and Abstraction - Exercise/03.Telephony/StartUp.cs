using System;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] websites = Console.ReadLine().Split(' ');

            Smartphone sm = new Smartphone();
            StationaryPhone st = new StationaryPhone();
            foreach (var num in phoneNumbers)
            {
                if (num.Length == 7)
                    st.Call(num);
                else
                    sm.Call(num);

            }

            foreach (var url in websites)
            {
                sm.BrowseURL(url);
            }
        }
    }
}
