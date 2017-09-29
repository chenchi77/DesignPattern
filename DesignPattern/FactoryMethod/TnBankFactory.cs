namespace DesignPattern.FactoryMethod
{
    public class TnBankFactory : IBankFactory
    {
        public IBank CreateBank()
        {
            return new TnBank();
        }
    }
}
