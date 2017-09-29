using System;

namespace DesignPattern.Decorator
{
    public class Person : IPerson
    {
        string _name;
        public Person(string name)
        {
            _name = name;
        }

        public string Show()
        {
            return $"My name is {_name}";
        }
    }
}
