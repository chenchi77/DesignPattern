using System;
namespace DesignPattern.Strategy
{
    public class Report
    {
        IFormatStrategy _strategy;
        public Report(IFormatStrategy strategy)
        {
            _strategy = strategy;
        }

        public string Print(){
            return _strategy.Output();
        }
    }
}
