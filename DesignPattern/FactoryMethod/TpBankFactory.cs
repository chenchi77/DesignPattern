namespace DesignPattern.FactoryMethod
{
    public class TpBankFactory : IBankFactory
    {
        public IBank CreateBank()
        {
            return new TpBank();
        }
    }
}
