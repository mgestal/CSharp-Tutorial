using System;

namespace Es.Udc.DotNet.CSharpTutorial
{

    /// <summary>
    /// Destructor Example
    /// </summary>
    class DestructorExample
    {
        DestructorExample()
        {
            Console.WriteLine("The Constructor has been executed");
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="DestructorExample"/> class.
        /// </summary>
        ~DestructorExample()
        {
            Console.WriteLine("The Destructor has been executed");
            Console.ReadLine();  // Console waits until it is destructed
        }

        #region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    new DestructorExample();
        //    Console.ReadLine();
        //}

        #endregion
    }
}