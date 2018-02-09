using designPatterns.classes.interfaces;

namespace designPatterns.classes.factory
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string color);
        public abstract IShape GetShape(string shape);
    }
}
