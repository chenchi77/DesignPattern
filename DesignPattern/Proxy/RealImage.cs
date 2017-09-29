namespace DesignPattern.Proxy
{
    public class RealImage : IImage
    {
        public string FileName; 
        public RealImage(string fileName)
        {
            FileName = fileName;
        }

        public string Display()
        {
            return $"Displaying {FileName}";
        }
    }
}
