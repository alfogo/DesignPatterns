using System;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;

namespace designPatterns.patterns.creational.abstractFactory.classes.shapes
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
