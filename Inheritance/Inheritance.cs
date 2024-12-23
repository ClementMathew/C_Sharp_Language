﻿using System;

namespace Inheritance
{
    class A
    {
        public int NumA { get; set; }

        public void MethodA() => Console.WriteLine("Method A from A");
    }

    class B : A
    {
        public int NumB { get; set; }

        new public void MethodA()
        {
            Console.WriteLine("Method A from B");

            base.MethodA();
        }

        public void MethodB() => Console.WriteLine("Method B from B");
    }

    class C : B
    {
        public int NumC { get; set; }

        public void MethodC() => Console.WriteLine("Method C from C");
    }

    internal class Inheritance
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.MethodA();
            c.MethodB();
            c.MethodC();
        }
    }
}
