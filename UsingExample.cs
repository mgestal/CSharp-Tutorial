using System;


namespace Es.Udc.DotNet.CSharpTutorial {

    /// <summary>
    /// Using statement
    /// </summary>
    class MyResource : IDisposable {

        public MyResource() {
            // Constructor should acquire valuable resource
            Console.WriteLine("Acquiring valuable resource");
        }

        public void Dispose() {
            // Dispose should release valuable resource
            Console.WriteLine("Releasing valuable resource");
        }

        public void DoSomething() {
            Console.WriteLine("Doing something...");
        }

        #region Test code. Uncomment for testing

        //static void Main()
        //{

        //    using (MyResource r = new MyResource())
        //    {
        //        r.DoSomething();
        //    } // r.Dispose() is automatically called

        //    Console.WriteLine("Now outside using statement");

        //    Console.ReadLine();

        //}

        #endregion
    }
}