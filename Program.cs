using Interface.Animal;
using Interface.Interfaces;
using Interface.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            ZooManager zoo=new ZooManager();

            IAnimal cat = new Cat();
            IAnimal dog = new Dog();
            IAnimal parrot = new Parrot();

            zoo.AddAnimal(cat);
            zoo.AddAnimal(dog);
            zoo.AddAnimal(parrot);


            Console.WriteLine("Animals making sounds:");
            zoo.MakeAllSounds();

            Console.WriteLine("\nFeeding animals:");
            zoo.FeedAllAnimals();

            Console.WriteLine("\nOur gifted bird:");
            zoo.SpeakParrot();

            Console.WriteLine("\nMoving:");
            zoo.MoveAllAnimals();
        }
    }
}
