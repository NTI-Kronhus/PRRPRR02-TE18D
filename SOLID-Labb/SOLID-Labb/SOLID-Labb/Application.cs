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
        private ApplicationDefaults _defaults;
        public Application(IAnimalIterator animalIterator, IAnimalFactory animalFactory)
        {
            _animalIterator = animalIterator;
            _animalFactory = animalFactory;
        }

        public void Run(ApplicationDefaults applicationDefaults = null)
        {
            _defaults = applicationDefaults ?? new ApplicationDefaults(_animalFactory);
            
            var animals = _defaults.Animals;
            _animalIterator.Iterate(animals);
        }
        
        

        
    }
}