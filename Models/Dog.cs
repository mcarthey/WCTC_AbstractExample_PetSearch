using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSearch.Models
{
    public class Dog : Pet
    {
        public Dog(string name)
        {
            Name = name;
        }

        public override void Display()
        {
            System.Console.WriteLine($"Dog name is {Name}");
        }
    }
}