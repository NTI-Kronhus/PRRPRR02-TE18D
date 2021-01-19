using System;
using SOLID_Labb.interfaces;

namespace SOLID_Labb.models
{
    internal class Dog : Animal
    {
        private string _owner = string.Empty;

        public Dog(string color, IPresenting presenter): base(color, 
            new Behavior
                {EatNoise = "Dog is barking!", 
                    SleepNoise = "Dog is sleeping!"}, presenter)
        {
            
        }

        public override void Speak()
        {
            Console.WriteLine("Dog is eating. " + _owner +" is happy!");
        }

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
    }
}
