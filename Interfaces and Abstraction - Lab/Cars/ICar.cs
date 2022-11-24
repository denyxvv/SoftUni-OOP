using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Cars
{
    public abstract class BaseCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }

    }
}
