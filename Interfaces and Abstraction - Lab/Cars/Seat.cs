using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }

        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public Seat(string model, string color, string start, string stop)
        {
            Model = model;
            Color = color;
            Start = start;
            Stop = stop;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Color} Seat {Model}");
            return sb.ToString();
        }
    }
}
