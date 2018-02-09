using designPatterns.classes.interfaces;

using System;
namespace designPatterns.classes.shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
