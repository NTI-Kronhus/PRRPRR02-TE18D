using System.Collections;
using System.Collections.Generic;
using SOLID_Labb.models;

namespace SOLID_Labb.interfaces
{
    public interface IAnimalIterator
    {
        public void Iterate(IEnumerable<Animal> animals);
    }
}