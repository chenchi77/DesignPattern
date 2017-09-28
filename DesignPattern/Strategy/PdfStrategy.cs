namespace DesignPattern.Strategy
{
    public class PdfStrategy : IFormatStrategy
    {
        public string Output()
        {
            return "Pdf";
        }
    }
}
