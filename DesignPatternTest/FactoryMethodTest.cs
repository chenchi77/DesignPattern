using DesignPattern.FactoryMethod;
using NUnit.Framework;

namespace DesignPatternTest
{
    [TestFixture]
    public class FactoryMethodTest
    {
        [Test]
        public void WhenUseTpBankWillReturnTpBankMethod()
        {
            var bankFactory = new TpBankFactory();
            var bank = bankFactory.CreateBank();
            Assert.AreEqual("TP Deposite", bank.Deposite());
            Assert.AreEqual("TP Withdraw", bank.Withdraw());
        }

		[Test]
		public void WhenUseTnBankWillReturnTnBankMethod()
		{
            var bankFactory = new TnBankFactory();
			var bank = bankFactory.CreateBank();
			Assert.AreEqual("TN Deposite", bank.Deposite());
			Assert.AreEqual("TN Withdraw", bank.Withdraw());
		}
    }
}
