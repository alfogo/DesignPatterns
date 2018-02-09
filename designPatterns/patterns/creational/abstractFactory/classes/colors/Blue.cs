using System;
using designPatterns.classes.interfaces;

namespace designPatterns.classes.colors
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}
