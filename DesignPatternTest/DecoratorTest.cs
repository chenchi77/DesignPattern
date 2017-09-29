using DesignPattern.Decorator;
using NUnit.Framework;

namespace DesignPatternTest
{
    [TestFixture]
    public class DecoratorTest
    {
        [Test]
        public void WhenUseDecoratorWillReturnDecoratorShortAndTShirt()
        {
			var person = new Person("Xiao Ming");
			var sh = new DecorationShort(person);
			var ts = new DecorationTShirt(sh);
			Assert.AreEqual("My name is Xiao Ming Decorator Short Decorator TShirt", ts.Show());
		}
    }
}
