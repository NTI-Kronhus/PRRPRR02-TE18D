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
            Speak(null);
        }
        internal virtual void Speak(string noise)
        {
            noise ??= _behavior.SpeakNoise;
            _presenter.DisplayOnLine(noise);
        }

        public virtual void Sleep()
        {
            Sleep(null);
        }
        
        internal virtual void Sleep(string noise)
        {
            noise ??= _behavior.SleepNoise;
            _presenter.DisplayOnLine(noise);
        }

        public virtual void Eat()
        {
            Eat(null);
        } 
        internal virtual void Eat(string noise)
        {
            noise ??= _behavior.EatNoise;
            _presenter.DisplayOnLine(noise);
        }
    }
}
