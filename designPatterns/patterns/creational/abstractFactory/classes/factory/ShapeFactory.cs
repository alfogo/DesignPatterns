using designPatterns.classes.shapes;
using designPatterns.classes.interfaces;

namespace designPatterns.classes.factory
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
