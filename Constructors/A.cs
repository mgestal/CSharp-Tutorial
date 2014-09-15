using System;

namespace Es.Udc.DotNet.CSharpTutorial.Constructors
{
    /// <summary>
    /// A class is the superclass within the hierarchy
    /// </summary>
    class A
    {
        public static int X;

        const int i = 1;

        /// <summary>
        /// Initializes the <see cref="A"/> class. Static constructor
        /// </summary>
        static A()
        {
            Console.WriteLine("A Constructor");
            X = 1;
        }

        # region Test code. Uncomment for testing

        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("A = " + A.X);
        //    Console.WriteLine("i = " + A.i);

        //    //Console.ReadLine();
        //}

        #endregion
    }
}
