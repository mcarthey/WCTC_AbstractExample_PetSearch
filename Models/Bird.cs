using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSearch.Models
{
    public class Bird : Pet
    {
        public Bird(string name)
        {
            Name = name;
        }
        public override void Display()
        {
            System.Console.WriteLine($"Bird name is {Name}");
        }
    }
}