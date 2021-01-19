using System.Collections.Generic;
using SOLID_Labb.Extentions;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;

namespace SOLID_Labb.services
{
    public class AnimalIterator : IAnimalIterator
    {
        private readonly IPresenting _display;

        public AnimalIterator(IPresenting display)
        {
            _display = display;
        }
        
        public void Iterate(IEnumerable<Animal> animals)
        {
            _display.WriteSeparator();
            
            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                    dog.TransferOwnership("Niklas");


                animal.Eat();
                animal.Sleep();
                animal.Speak();
                
                animal.Color = "Grey";
                
                _display.DisplayOnLine($"{animal.GetType().Name} is {animal.Color} \n");

                _display.WriteSeparator();
            }
        }
        
        
    }
}