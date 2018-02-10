﻿using System;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;

namespace designPatterns.patterns.creational.abstractFactory.classes.shapes
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
