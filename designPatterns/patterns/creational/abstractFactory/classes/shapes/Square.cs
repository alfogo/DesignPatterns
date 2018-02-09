using designPatterns.classes.interfaces;

using System;
namespace designPatterns.classes.shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
