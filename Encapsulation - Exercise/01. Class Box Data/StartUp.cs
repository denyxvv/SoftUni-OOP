using System;

namespace Box
{
    public class StartUp
    {
        static void Main(string[] args)
        {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
            try
            {
                Box box = new Box(length, width, height);
                Console.WriteLine(box);

            }
            catch (ArgumentException x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
