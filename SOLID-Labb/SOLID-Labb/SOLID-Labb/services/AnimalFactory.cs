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
            var type = typeof(T);
            return type switch
            {
                _ when type == typeof(Bird) => new Bird(color, _display),
                _ when type == typeof(Dog) => new Dog(color, _display),
                _ when type == typeof(Hedgehog) => new Hedgehog(color, _display),
                _ => null
            };
        }
    }
}