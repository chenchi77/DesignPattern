using System;

namespace DesignPattern.Decorator
{
    public abstract class Decorator : IPerson
    {
        IPerson _decoratedPerson;
        public Decorator(IPerson decoratedPerson)
        {
            _decoratedPerson = decoratedPerson;
        }

        public virtual string Show()
        {
            return $"{_decoratedPerson.Show()} Decorator";
        }
    }
}
