namespace DesignPattern.Strategy
{
    public class WordStrategy : IFormatStrategy
    {
        public string Output()
        {
            return "Word";
        }
    }
}
