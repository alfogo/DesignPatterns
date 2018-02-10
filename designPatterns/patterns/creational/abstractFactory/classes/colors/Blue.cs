using System;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;

namespace designPatterns.patterns.creational.abstractFactory.classes.colors
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}
