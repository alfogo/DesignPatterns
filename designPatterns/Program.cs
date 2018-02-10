using System;
using designPatterns.patterns.creational.abstractFactory.classes.factory;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;
using designPatterns.patterns.behavioral.observer.classes;
using designPatterns.patterns.behavioral.observer.classes.observers;

namespace designPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory();

            Observer();
        }

        /////////////////////////
        // CREATIONAL PATTERNS //
        /////////////////////////
        static void AbstractFactory()
        {
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

        /////////////////////////
        // BEHAVIORAL PATTERNS //
        /////////////////////////

        static void Observer()
        {
            Console.WriteLine("=================");
            Console.WriteLine("Observer pattern");
            Console.WriteLine("=================");

            Subject subject = new Subject();

            new HexalObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            Console.WriteLine("Second state change: 10");
            subject.SetState(10);

        }

        /////////////////////////
        // STRUCTURAL PATTERNS //
        /////////////////////////


    }
}
