﻿using System;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;

namespace designPatterns.patterns.creational.abstractFactory.classes.shapes
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
