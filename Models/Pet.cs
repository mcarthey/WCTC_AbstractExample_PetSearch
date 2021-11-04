using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractSearch.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }

        public abstract void Display();
    }
}