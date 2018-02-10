using System;
using System.Collections.Generic;
using System.Text;

namespace designPatterns.patterns.behavioral.observer.classes
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();

    }
}
