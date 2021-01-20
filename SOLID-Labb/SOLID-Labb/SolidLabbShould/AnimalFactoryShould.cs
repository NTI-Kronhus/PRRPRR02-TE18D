using Moq;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;
using SOLID_Labb.services;
using Xunit;

namespace SolidLabbShould
{
    public class AnimalFactoryShould
    {
        [Fact]
        public void CreateAnimalShould()
        {
            var displayMoq = new Mock<IPresenting>().Object;

            var instance = new AnimalFactory(displayMoq);

            var bird = instance.CreateAnimal<Bird>("orange");
            var dog = instance.CreateAnimal<Dog>("orange");
            var hedgehog = instance.CreateAnimal<Hedgehog>("orange");

            Assert.True(bird is Bird);
            Assert.True(dog is Dog);
            Assert.True(hedgehog is Hedgehog);
            
            
        } 
    }
}