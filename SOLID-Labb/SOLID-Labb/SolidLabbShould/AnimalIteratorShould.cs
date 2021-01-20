using System;
using System.Collections.Generic;
using Moq;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;
using SOLID_Labb.services;
using Xunit;

namespace SolidLabbShould
{
    public class AnimalIteratorShould
    {
        [Fact]
        public void IterateShould()
        {
            var mockDisplay = new Mock<IPresenting>();
            var factory = new AnimalFactory(mockDisplay.Object);
            var animals = new List<Animal>
                {factory.CreateAnimal<Dog>(""), factory.CreateAnimal<Bird>(""), factory.CreateAnimal<Hedgehog>("")};
            
            var instance = new AnimalIterator(mockDisplay.Object);

            instance.Iterate(animals);

            animals.ForEach(x =>
            {
                Assert.Equal("Grey", x.Color);
            });
            
            mockDisplay.Verify(c => c.DisplayOnLine(It.IsAny<string>()), Times.AtLeast(2));
        }
    }
}