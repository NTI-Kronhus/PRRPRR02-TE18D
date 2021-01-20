using System.Collections;
using System.Collections.Generic;
using SOLID_Labb.interfaces;

namespace SOLID_Labb.models
{
    public class ApplicationDefaults
    {
        private readonly IAnimalFactory _factory;
        private IEnumerable<Animal> _animals;

        public IEnumerable<Animal> Animals
        {
            get
            {
                if (_animals != null)
                    return _animals;
                _animals = CreateAnimals();
                return Animals;
            }
            set => _animals = value;
        }
        
        
        public ApplicationDefaults(IAnimalFactory factory)
        {
            _factory = factory;
        }
        
        private IEnumerable<Animal> CreateAnimals()
        {
            IList<Animal> output = new List<Animal>();

            output.Add(_factory.CreateAnimal<Dog>("Black"));
            output.Add(_factory.CreateAnimal<Hedgehog>("Pink"));
            output.Add(_factory.CreateAnimal<Bird>("Yellow"));
            return output;
        }
    }
}