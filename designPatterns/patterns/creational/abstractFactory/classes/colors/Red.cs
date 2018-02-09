using System;
using designPatterns.classes.interfaces;

namespace designPatterns.classes.colors
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
