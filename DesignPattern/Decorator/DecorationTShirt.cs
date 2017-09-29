using System;

namespace DesignPattern.Decorator
{
    public class DecorationTShirt : Decorator
    {
        public DecorationTShirt(IPerson decoratedPerson) : base(decoratedPerson)
        {
        }

        public override string Show()
        {
            return $"{base.Show()} TShirt";
        }
    }
}
