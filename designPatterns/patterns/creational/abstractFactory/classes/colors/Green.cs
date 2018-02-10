using System;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;

namespace designPatterns.patterns.creational.abstractFactory.classes.colors
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
