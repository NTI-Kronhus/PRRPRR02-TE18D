using System;
using SOLID_Labb.interfaces;

namespace SOLID_Labb.services
{
    public class ConsolePresenter : IPresenting
    {
        public void DisplayOnLine(string content)
        {
            Console.WriteLine(content);
        }

        public void Display(string content)
        {
            Console.Write(content);
        }
    }
}