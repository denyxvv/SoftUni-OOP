using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Robot
    {
        public string Name { get; }
        public string Id { get; set; }

        public Robot(string model, string id)
        {
            Name = model;
            Id = id;
        }
        public void Check(string fakeString)
        {
            if (Id.EndsWith(fakeString))
                Console.WriteLine(Id);
        }
    }
}
