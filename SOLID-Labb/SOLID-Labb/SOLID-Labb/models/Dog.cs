using System;
using SOLID_Labb.interfaces;

namespace SOLID_Labb.models
{
    public class Dog : Animal
    {
        private readonly IPresenting _presenter;
        private string _owner = string.Empty;

        public Dog(string color, IPresenting presenter): base(color, 
            new Behavior
                {EatNoise = "Dog is barking!", 
                    SleepNoise = "Dog is sleeping!"}, presenter)
        {
            _presenter = presenter;
        }

        public override void Speak()
        {
            _presenter.DisplayOnLine("Dog is eating. " + _owner +" is happy!");
        }

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
    }
}
