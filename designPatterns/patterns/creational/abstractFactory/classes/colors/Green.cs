using System;
using designPatterns.classes.interfaces;

namespace designPatterns.classes.colors
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
