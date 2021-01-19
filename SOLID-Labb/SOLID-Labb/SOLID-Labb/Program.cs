using System;
using Autofac;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;
using SOLID_Labb.services;

namespace SOLID_Labb
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var container = BuildContainer();
            var display = container.Resolve<IPresenting>();
            
            
            
            Animal[] animals = {new Dog("Black", display),
                                new Hedgehog("Pink", display),
                                new Bird("Yellow", display)};

            display.DisplayOnLine("############### \n");

            foreach (var animal in animals)
            {
                if (animal is Dog dog)
                    dog.TransferOwnership("Niklas");
                

                animal.Eat();
                animal.Sleep();
                animal.Speak();
                animal.Color = "Grey";
                display.DisplayOnLine($"{animal.GetType().Name} is {animal.Color} \n");

                display.DisplayOnLine("############### \n");
            }
        }


        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ConsolePresenter>().As<IPresenting>().InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}
