namespace DesignPattern.SimpleFactory
{
    public enum Aminal{
        Dog,
        Cat
    }

    public static class Factory
    {
        public static IAminal Create(Aminal aminal)
        {
            switch(aminal){
                case Aminal.Dog:
                    return new Dog();
                case Aminal.Cat:
                    return new Cat();
                default:
                    return null;
            }
        }
    }
}
