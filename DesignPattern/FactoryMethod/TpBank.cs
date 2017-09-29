namespace DesignPattern.FactoryMethod
{
    public class TpBank : IBank
    {
        public string Deposite()
        {
            return "TP Deposite";
        }

        public string Withdraw()
        {
            return "TP Withdraw";
        }
    }
}
