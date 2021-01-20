using SOLID_Labb.services;
using Xunit;

namespace SolidLabbShould
{
    public class ConsolePresenterShould
    {
        [Fact]
        public void DisplayOnLine()
        {
            var instance = new ConsolePresenter();
            instance.DisplayOnLine("test");
        }

        [Fact]
        public void Display()
        {
            var instance = new ConsolePresenter();
            instance.Display("test");
        }
    }
}