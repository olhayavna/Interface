using Interface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Animal
{
    public class Cat: IAnimal
    {
        public void MakeSound ()
            {
            Console.WriteLine("Cat: Meow!");
        }
        public void Eat()
        {
            Console.WriteLine("Cat is eating fish.");
        }
        public void Move()
        {
            Console.WriteLine("Cat is running.");
        }

    }
}
