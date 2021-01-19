using System;
using System.Collections.Generic;
using System.Text;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;

namespace SOLID_Labb.models
{
    public abstract class Animal
    {
        private readonly Behavior _behavior;
        private readonly IPresenting _presenter;
        public string Color;

        protected Animal(string color, Behavior behavior, IPresenting presenter)
        {
            Color = color;
            _behavior = behavior;
            _presenter = presenter;
        }

        public virtual void Speak()
        {
            _presenter.DisplayOnLine(_behavior.SpeakNoise);
        }

        public virtual void Sleep()
        {
            _presenter.DisplayOnLine(_behavior.SleepNoise);
        }

        public virtual void Eat()
        {
            _presenter.DisplayOnLine(_behavior.EatNoise);
        }
    }
}
