using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Interfaces;

namespace Interface.Animal
{
    public class Dog: IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog: Woof!");
        }

       public void Eat()   
        { 
            Console.WriteLine("Dog is eating a bone.");
        }
        public void Move()
        {
            Console.WriteLine("Dog is running.");
        }

    }
}
