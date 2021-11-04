using System.Collections.Generic;
using AbstractSearch.Models;

namespace AbstractSearch
{
    public class PetStoreManager
    {

        public List<Pet> Pets {get;set;}


        public PetStoreManager()
        {
            Pets = new List<Pet>();
        }
    }
}