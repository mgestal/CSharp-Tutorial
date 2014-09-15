using System;
using System.Collections.Generic;
using System.Text;

namespace Es.Udc.DotNet.CSharpTutorial.Constructors
{
    /// <summary>
    /// Example: this statement 
    /// </summary>
    class SuperClass
    {
        private string argument1;

        /// <summary>
        /// Initializes a new instance of the <see cref="SuperClass"/> class.
        /// </summary>
        public SuperClass() : this("<Default arg1>") { }

        /// <summary>
        /// Initializes a new instance of the <see cref="SuperClass"/> class.
        /// </summary>
        /// <param name="arg1">The arg1.</param>
        public SuperClass(string arg1)
        {
            this.argument1 = arg1;
            Console.WriteLine("Arguments: " + argument1);
        }

        # region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    // Creating a SuperClass instance
        //    SuperClass sc = new SuperClass();
        //    //Console.ReadLine();
        //}

        #endregion
    }
}