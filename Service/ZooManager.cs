using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Animal;
using Interface.Interfaces;


namespace Interface.Service
{
    public class ZooManager
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void MakeAllSounds()
        {
            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        public void FeedAllAnimals()
        {
            foreach (var animal in animals)
            {
                animal.Eat();
            }
        }

        public void SpeakParrot()
        {
            foreach(var animal in animals)
            {
                if (animal is Parrot parrot)
                {
                    parrot.Speak();
                }
            }
        }

        public void MoveAllAnimals()
        {
            foreach( var animal in animals)
            {
                animal.Move();
            }
        }
    }
}
