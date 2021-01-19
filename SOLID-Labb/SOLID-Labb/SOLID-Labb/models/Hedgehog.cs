using SOLID_Labb.interfaces;

namespace SOLID_Labb.models
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string color, IPresenting presenter): base(color, 
            new Behavior
                {EatNoise = "Hedgehog is squeaking!", 
                    SleepNoise = "Hedgehog is napping!", 
                    SpeakNoise = "Hedgehog is omnomnoming!"}, presenter)
        {
            
        }
    }
}
