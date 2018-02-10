namespace designPatterns.patterns.creational.abstractFactory.classes.factory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("SHAPE"))
            {
                return new ShapeFactory();

            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}
