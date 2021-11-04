using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSearch.Models
{
    public class Cat: Pet
    {
        public Cat(string name)
        {
            Name = name;
        }
public override void Display()
        {
            System.Console.WriteLine($"Cat name is {Name}");
        }
    }
}