using System;
using System.Collections.Generic;
using System.Text;

namespace designPatterns.patterns.behavioral.observer.classes.observers
{
    public class HexalObserver : Observer
    {
        public HexalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hexal String: " + (subject.GetState().ToString()));
        }
    }
}
