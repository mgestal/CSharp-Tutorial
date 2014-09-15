using System;
using System.Collections.Generic;
using System.Text;

namespace Es.Udc.DotNet.CSharpTutorial.Constructors
{
    /// <summary>
    /// B class is a child of A class
    /// </summary>
    class B : A
    {
        /// <summary>
        /// Initializes the <see cref="B"/> class. Static constructor
        /// </summary>
        static B()
        {
            Console.WriteLine("B Constructor");
            B.X = 2;
        }

        # region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    /* B Constructor is called because B is a static class
        //     * When B.X is called (inherited attribute from A) A empty 
        //     * constructor is called. Then 2 is asigned to X.
        //     */
        //    Console.WriteLine(B.X);
        //    //Console.ReadLine();
        //    /* Shows:
        //     *      B Constructor
        //     *      A Constructor
        //     *      2
        //     */
        //}

        #endregion
    }
}