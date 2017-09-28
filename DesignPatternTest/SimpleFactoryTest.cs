using DesignPattern.SimpleFactory;
using NUnit.Framework;

namespace DesignPatternTest
{
    [TestFixture]
    public class SimpleFactoryTest
    {
        [TestCase(Aminal.Dog, ExpectedResult = "Growl")]
        [TestCase(Aminal.Cat, ExpectedResult = "Meow")]
        public string WhenFactoyUseDifferentAminalWillReturnDifferentSound(Aminal aminal)
        {
            var factory = Factory.Create(aminal);
            return factory.Sound();
        }
    }
}
