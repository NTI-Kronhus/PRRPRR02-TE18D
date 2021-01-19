using SOLID_Labb.models;

namespace SOLID_Labb.interfaces
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal<T>(string color) where T : Animal;
    }
}