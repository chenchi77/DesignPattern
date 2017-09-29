namespace DesignPattern.Proxy
{
    public class ProxyImage : IImage
    {
        IImage image;
        public ProxyImage(string fileName)
        {
            LoadImage(fileName);
        }

        public void LoadImage(string fileName)
        {
            if (image == null)
                image = new RealImage(fileName);
        }

        public string Display()
        {
            return image.Display();
        }
    }
}
