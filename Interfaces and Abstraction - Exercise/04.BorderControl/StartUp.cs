using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _04.BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBirthdatable> humansAndPets = new List<IBirthdatable>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split();
                if (tokens[0] == "Citizen")
                    humansAndPets.Add(new Citizen(tokens[1], int.Parse(tokens[2]), tokens[3], tokens[4]));
                else if (tokens[0] == "Pet")
                    humansAndPets.Add(new Pet(tokens[1], tokens[2]));

                command = Console.ReadLine();
            }
            string targetYear = Console.ReadLine();
            IEnumerable<string> filteredBirthdates = humansAndPets
                .Where(x => x.BirthYearOnly == targetYear)
                .Select(x => x.BirthDate);

            if (filteredBirthdates.Any())
                Console.WriteLine(String.Join(Environment.NewLine, filteredBirthdates));

        }
    }
}
