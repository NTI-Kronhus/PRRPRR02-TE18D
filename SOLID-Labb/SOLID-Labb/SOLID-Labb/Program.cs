using System;
using System.Collections.Generic;
using Autofac;
using SOLID_Labb.interfaces;
using SOLID_Labb.models;
using SOLID_Labb.services;

namespace SOLID_Labb
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var container = BuildContainer();
            var app = container.Resolve<Application>();
            
            try
            {
                app.Run();
            }
            catch (Exception error)
            {
                Console.WriteLine($"An Error Seems to have occured :( :{error.Message}");
                Console.ReadLine();
            }
        }
        




        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().AsSelf().InstancePerLifetimeScope();
            
            builder.RegisterType<ConsolePresenter>().As<IPresenting>().InstancePerLifetimeScope();
            builder.RegisterType<AnimalFactory>().As<IAnimalFactory>().InstancePerLifetimeScope();
            builder.RegisterType<AnimalIterator>().As<IAnimalIterator>().InstancePerLifetimeScope();
            
            return builder.Build();
        }
    }
}
