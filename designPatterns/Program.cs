using System;
using designPatterns.classes.factory;
using designPatterns.classes.interfaces;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////
            // ABSTRACT FACTORY //
            //////////////////////

            Console.WriteLine("========================");
            Console.WriteLine("Abstract Factory pattern");
            Console.WriteLine("========================");
            



            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");

            //get an object of Shape Circle
            IShape shape1 = shapeFactory.GetShape("CIRCLE");

            //call Draw method of Shape Circle
            shape1.Draw();

            //get an object of Shape Rectangle
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");

            //call Draw method of Shape Rectangle
            shape2.Draw();

            //get an object of Shape Square 
            IShape shape3 = shapeFactory.GetShape("SQUARE");

            //call Draw method of Shape Square
            shape3.Draw();

            //get color factory
            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");

            //get an object of Color Red
            IColor color1 = colorFactory.GetColor("RED");

            //call Fill method of Red
            color1.Fill();

            //get an object of Color Green
            IColor color2 = colorFactory.GetColor("GREEN");

            //call Fill method of Green
            color2.Fill();

            //get an object of Color Blue
            IColor color3 = colorFactory.GetColor("BLUE");

            //call Fill method of Color Blue
            color3.Fill();
        }
    }
}
