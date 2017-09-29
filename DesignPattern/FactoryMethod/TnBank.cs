namespace DesignPattern.FactoryMethod
{
    public class TnBank : IBank
    {
		public string Deposite()
		{
			return "TN Deposite";
		}

		public string Withdraw()
		{
			return "TN Withdraw";
		}
    }
}
