﻿using System;
using System.Collections.Generic;
using System.Text;

namespace designPatterns.patterns.behavioral.observer.classes.observers
{
    public class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + (subject.GetState().ToString()));
        }
    }
}
