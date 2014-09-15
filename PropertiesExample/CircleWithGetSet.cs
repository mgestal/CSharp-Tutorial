using System;

namespace Es.Udc.DotNet.CSharpTutorial.PropertiesExample
{
    /* Traditional Encapsultation Without Properties */
    class CircleWithGetSet
    {
        private double radius;

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        //public static void Main()
        //{
        //    CircleWithGetSet circle = new CircleWithGetSet();

        //    // Set
        //    circle.SetRadius(1);

        //    // Get
        //    Console.WriteLine("Radius: " + circle.GetRadius());
        //}
    }
}
