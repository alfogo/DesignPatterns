using System;
using designPatterns.classes.interfaces;

namespace designPatterns.classes.shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
