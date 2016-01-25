using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava6olio
{
    class Program
    {
        static void Main(string[] args)
        {
            // luo opiskelijat
            Dog dog1 = new Dog();
            dog1.Name = "Cookie";
            dog1.Breed = "Huskymix";
            dog1.Age = 0;

            Dog dog2 = new Dog();
            dog2.Name = "Vilma";
            dog2.Breed = "Mix";
            dog2.Age = 5;

            // display car data
            dog1.PrintData();
            dog2.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            dog1.GetOlder();
            dog2.GetOlder();
            // display car data again, notice changed speed value!
            dog1.PrintData();
            dog2.PrintData();
            Console.ReadLine();
        }
    }
}
