using designPatterns.patterns.creational.abstractFactory.classes.shapes;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;
using designPatterns.patterns.creational.abstractFactory.classes.colors;

namespace designPatterns.patterns.creational.abstractFactory.classes.factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }
        public override IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }

            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
