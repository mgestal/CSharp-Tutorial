using System;
using System.Collections.Generic;
using System.Text;

namespace Es.Udc.DotNet.CSharpTutorial.PropertiesExample
{
    /// <summary>
    /// Using properties
    /// </summary>
    class CircleWithAutoImplementedProperties
    {

        /// <summary>
        /// Property that Gets or sets the radius.
        /// </summary>
        /// <value>
        /// The radius.
        /// </value>
        /// <remarks>NOTE that automatically implemented properties must define both get and set accessors.</remarks>
        public double Radius { get; set; }

        /* 
         */
        /// <summary>
        /// Property that Gets the diameter.
        /// </summary>
        /// <value>
        /// The diameter.
        /// </value>
        /// <remarks>But it's possible to use private access modifier to define a read only or a write only propertie</remarks>
        public double Diameter { get; private set; }

        //public static void Main()
        //{
        //    CircleWithAutoImplementedProperties circle =
        //        new CircleWithAutoImplementedProperties();

        //    // Set
        //    circle.Radius = 1;

        //    // Get
        //    Console.WriteLine("Radius: " + circle.Radius);
        //}
    }
}
