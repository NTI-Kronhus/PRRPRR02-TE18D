using SOLID_Labb;
using SOLID_Labb.services;
using Xunit;

namespace SolidLabbShould
{
    public class ApplicationShould
    {
        [Fact]
        public void RunShould()
        {
            var display = new ConsolePresenter();
            var instance = new Application(new AnimalIterator(display), new AnimalFactory(display));
            instance.Run();
        }
    }
}