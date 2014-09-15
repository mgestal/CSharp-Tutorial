using System;

namespace Es.Udc.DotNet.CSharpTutorial.Constructors {
    
    /// <summary>
    /// Static and Non-Static Constructors
    /// </summary>
    class StaticConstructorExample {

        static StaticConstructorExample() {
            Console.WriteLine("The Static Constructor has been executed");
        }

        public StaticConstructorExample() {
            Console.WriteLine("The Non-Static Constructor has been executed");
        }

        # region Test code. Uncomment for testing

        //public static void Main()
        //{

        //    new StaticConstructorExample();  // create a StaticConstructorExample instance
        //    //Console.ReadLine();
        //}

        #endregion
    }
}
