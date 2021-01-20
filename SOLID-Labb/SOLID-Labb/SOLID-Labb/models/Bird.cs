using SOLID_Labb.interfaces;

namespace SOLID_Labb.models
{
    public class Bird : Animal
    {
        public Bird(string color, IPresenting presenter): 
            base(color, 
                new Behavior
                    {EatNoise = "Bird is chirping!", 
                        SleepNoise = "Bird is sleeping!", 
                        SpeakNoise = "Bird is peck-peck-pecking away!"}, presenter)
        { }
    }
}
