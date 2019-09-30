using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MiscCode
{
    public class CircleEx
    {
        public static void DoStuff()
        {
            var C = new Circle(10.0);

            double circ = C.Calculate((r) => 2 * Math.PI * r);

            Console.WriteLine($"circunference: {circ}");
        }

        // public delegate TResult Func<in T,out TResult>(T arg);
        public static void getProp(Circle C)
        {
            // using reflection to get the private property
            var field = C.GetType().GetField("_radius", BindingFlags.Instance | BindingFlags.NonPublic);
            var rad = field.GetValue(C);
            //field.SetValue(cir, 5);
            Console.WriteLine($"radius: {rad}");
        }
        public static void testFunc()
        {
            Func<string, string> convert = s => s.ToUpper();
            string name = "Dakota";
            Console.WriteLine(convert(name));
        }
    }

    public sealed class Circle
    {
        private double _radius;

        public Circle(double rad)
        {
            _radius = rad;
        }
        public double Calculate(Func<double, double> op)
        {
            return op(_radius);
        }
    }
    // error: 
    // Error CS0509  'myCircle': cannot derive from sealed type 'Circle'
    // public class myCircle : Circle { }
}
