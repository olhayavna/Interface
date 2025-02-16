using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Interfaces;

namespace Interface.Animal
{
    public class Parrot:IAnimal
    {
        private Random random = new Random();
        public void MakeSound()
        {
            Console.WriteLine("Parrot: Squawk!");
        }
        public void Eat()
        {
            Console.WriteLine("Parrot is eating seeds.");
        }

        public void Speak()
        {
            string[] phrases =
        {
            "Hello!",
            "I can mimic sounds!",
            "Give me a cracker!",
            "Who's a good bird?",
            "Pretty bird!",
            "I love eating"
        };
            Console.WriteLine($"Parrot: {phrases[random.Next(phrases.Length)]}");

        }

        public void Move()
        {
            Console.WriteLine("Parrot is flying.");
        }

    }
}
