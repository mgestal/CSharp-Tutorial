using System;

namespace Es.Udc.DotNet.CSharpTutorial.PropertiesExample
{
    /* Encapsulating Type State with Properties */
    class CircleWithProperties
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
            /* NOTE: 'value' is a C# reserved word. */
            set { radius = value; }
        }

        //public double Radius
        //{
        //    private get { return radius; }
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            this.radius = 0;
        //        }
        //        else
        //        {
        //            this.radius = value;
        //        }
        //    }
        //}


        //public static void Main()
        //{
        //    CircleWithProperties circle = new CircleWithProperties();

        //    // Set
        //    circle.Radius = 1;

        //    // Get
        //    Console.WriteLine("Radius: " + circle.Radius);
        //}
    }
}
