using System;
using System.Collections.Generic;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;

namespace SOLID_Labb
{
    public class Application
    {
        private readonly IAnimalIterator _animalIterator;
        private readonly IAnimalFactory _animalFactory;

        public Application(IAnimalIterator animalIterator, IAnimalFactory animalFactory)
        {
            _animalIterator = animalIterator;
            _animalFactory = animalFactory;
        }

        public void Run()
        {
            var animals = CreateAnimals();
            _animalIterator.Iterate(animals);
        }
        
        
        private IEnumerable<Animal> CreateAnimals()
        {
            IList<Animal> animals = new List<Animal>();

            animals.Add(_animalFactory.CreateAnimal<Dog>("Black"));
            animals.Add(_animalFactory.CreateAnimal<Hedgehog>("Pink"));
            animals.Add(_animalFactory.CreateAnimal<Bird>("Yellow"));
            return animals;
        }
        
    }
}