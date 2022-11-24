using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.BorderControl
{
    public class Citizen : IBirthdatable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }
        public string BirthYearOnly => this.BirthDate.Split('/').Last();

        public Citizen(string name, int age, string id, string birthDate)
        {
                Name = name;
                Age = age;
                Id = id;
                BirthDate = birthDate;
        }
        public void Check(string fakeString)
        {
            if (Id.EndsWith(fakeString))
                Console.WriteLine(Id);
        }

        
    }
}
