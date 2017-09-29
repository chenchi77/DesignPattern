using DesignPattern.Proxy;
using NUnit.Framework;

namespace DesignPatternTest
{
    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void WhenProxyImageWillReturnProxyResult()
        {
            var image = new ProxyImage("Picture.jpg");
            Assert.AreEqual("Displaying Picture.jpg", image.Display());
        }
    }
}
