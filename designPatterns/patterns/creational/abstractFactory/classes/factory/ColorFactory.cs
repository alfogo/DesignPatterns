using designPatterns.patterns.creational.abstractFactory.classes.colors;
using designPatterns.patterns.creational.abstractFactory.classes.interfaces;

namespace designPatterns.patterns.creational.abstractFactory.classes.factory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }

            if (color.Equals("RED"))
            {
                return new Red();

            }
            else if (color.Equals("GREEN"))
            {
                return new Green();

            }
            else if (color.Equals("BLUE"))
            {
                return new Blue();
            }

            return null;

        }
        public override IShape GetShape(string shapeType)
        {
            return null;
        }
    }
}
