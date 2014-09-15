using System;


namespace Es.Udc.DotNet.CSharpTutorial.Generics
{
 
    /// <summary>
    /// A list implementation without Generics
    /// </summary>
    class List
    {
        private object[] elements;   // array to store list elements
        private int count = 0;       // number of elements in the list

        /// <summary>
        /// Initializes a new instance of the <see cref="List"/> class.
        /// </summary>
        public List()
        {
            elements = new object[1];
        }

        /// <summary>
        /// Adds the specified element to the list.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Add(object element)
        {
            if (count == elements.Length)
            {
                Resize();
            }
            elements[count++] = element;
        }

        /// <summary>
        /// Resizes the list.
        /// </summary>
        private void Resize()
        {
            int length = elements.Length;
            object[] newElements = new object[2 * length];

            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
        }

        /// <summary>
        /// Gets or sets the <see cref="System.Object"/> at the specified index.
        /// </summary>
        public object this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        #region Properties

        public int Count
        {
            get { return count; }
        }

        public int Length
        {
            get { return elements.Length; }
        }

        #endregion
    }


    class TestListWithoutGenerics
    {
        # region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    List intList = new List();

        //    intList.Add(1);           // Argument is boxed           
        //    intList.Add(2);           // Argument is boxed           
        //    intList.Add("Three");     // Should be an error           

        //    int i = (int)intList[0];  // Cast required

        //    for (int j = 0; j < intList.Length; j++)
        //    {
        //        Console.WriteLine(intList[j]);
        //    }

        //    //Console.ReadLine();
        //}

        #endregion
    }
}
