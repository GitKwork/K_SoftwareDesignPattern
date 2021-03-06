using System;
using System.Linq;

namespace Ex53_DependencyInversionPrinciple
{
    public class SearchByAge
    {
        ListStorage storage;
        public SearchByAge(ListStorage storage) => this.storage = storage;

        public void Search()
        {
            foreach (var p in storage.GetPersons()
                                     .Where(e => e.Age > 45))
            {
                Console.WriteLine($"{p.FirstName} {p.Age}");
            }
            Console.WriteLine();
        }
    }


}
