using System;

namespace DesignPattern.Decorator
{
    public class DecorationShort : Decorator
    {
        public DecorationShort(IPerson decoratedPerson) : base(decoratedPerson)
        {
        }

		public override string Show()
		{
			return $"{base.Show()} Short";
		}
    }
}
