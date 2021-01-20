using System;
using System.Runtime.CompilerServices;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;

namespace SOLID_Labb.services
{
    public class AnimalFactory : IAnimalFactory
    {
        private readonly IPresenting _display;
        
        
        public AnimalFactory(IPresenting display)
        {
            _display = display;
        }

        public Animal CreateAnimal<T>(string color) where T : Animal
        {
            return (T) Activator.CreateInstance(typeof(T), new object[] {new string(color), _display});
        }
    }
}