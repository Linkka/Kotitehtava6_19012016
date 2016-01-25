using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio
{
    class Dog
    {
        // properties
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void GetOlder()
        {
            Age += 1;
        }

        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Dog information : ");
            Console.WriteLine("- Name : " + Name);
            Console.WriteLine("- Breed : " + Breed);
            Console.WriteLine("- Age : " + Age);
        }

        // destructor
        ~Dog()
        {
            Console.WriteLine("Dog object destroyed.");
        }

    }
}
