using System;
using System.Collections.Generic;
using System.Text;

namespace Es.Udc.DotNet.CSharpTutorial.Constructors
{

    /// <summary>
    /// Example: calls to base class. base statement
    /// </summary>
    class ChildClass : SuperClass
    {
        private string argument2;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildClass"/> class.
        /// It class other constructor to complete the process
        /// </summary>
        public ChildClass() : this("<Default arg2>") { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildClass"/> class.
        /// </summary>
        /// <param name="arg2">The arg2.</param>
        public ChildClass(string arg2)
        {
            this.argument2 = arg2;
            Console.WriteLine("Arguments: " + argument2);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChildClass"/> class.
        /// The base() sentence references the parent constructor
        /// </summary>
        /// <param name="arg1">The arg1.</param>
        /// <param name="arg2">The arg2.</param>
        public ChildClass(string arg1, string arg2)
            : base(arg1)
        {
            this.argument2 = arg2;
            Console.WriteLine("Arguments: " + argument2);
        }

        # region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    SuperClass sc = new SuperClass();
        //    /* Shows:
        //     * Arguments: <Default arg1>
        //     */

        //    ChildClass cc = new ChildClass();
        //    /* Shows:
        //     * Arguments: <Default arg1>
        //     * Arguments: <Default arg2>
        //     */

        //    ChildClass cc2 = new ChildClass("1", "2");
        //    /* Shows:
        //     * Arguments: 1
        //     * Arguments: 2
        //     */

        //    //Console.ReadLine();
        //}

        #endregion
    }
}
