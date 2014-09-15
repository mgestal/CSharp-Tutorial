using System;
using System.Collections.Generic;
using System.Text;

namespace Es.Udc.DotNet.CSharpTutorial
{
    /// <summary>
    /// Using structs
    /// </summary>
    class StructExample
    {

        /// <remarks> 
        /// Note that it is possible to define a struct outside of a class definition
        /// </remarks>
        struct Point
        {
            private int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int X
            {
                get { return x; }
                set { x = value; }
            }
            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            //<<...>>

        }

        # region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    Point p = new Point(2, 5);
        //    p.X += 100;
        //    int px = p.X;   // px = 102

        //    Console.WriteLine("px: " + px);
        //}

        # endregion
    }
}
