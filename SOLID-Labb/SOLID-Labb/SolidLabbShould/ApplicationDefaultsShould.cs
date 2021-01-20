using System.Collections.Generic;
using System.Linq;
using Moq;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;
using SOLID_Labb.services;
using Xunit;

namespace SolidLabbShould
{
    public class ApplicationDefaultsShould
    {
        [Fact]
        public void AnimalsShould()
        {
            var factory = new Mock<IAnimalFactory>();
            
            factory
                .Setup(x => x.CreateAnimal<Animal>(""))
                .Returns(new Dog("", new ConsolePresenter()));
            
            var instance = new ApplicationDefaults(factory.Object);

            var animals = instance.Animals;
            
            Assert.Equal(3, animals.Count());

            instance.Animals = new List<Animal>();
            
            Assert.Empty(instance.Animals);
        }
    }
}