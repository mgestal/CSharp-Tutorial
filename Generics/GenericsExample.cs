using System;


namespace Es.Udc.DotNet.CSharpTutorial.Generics
{

    /// <summary>
    /// A list implementation using Generics 
    /// </summary>
    /// <typeparam name="ItemType">The type of the items stored in the list.</typeparam>
    class List<ItemType>
    {
        /// <summary>
        /// The elements included in the list
        /// </summary>
        private ItemType[] elements;
        
        /// <summary>
        /// Number of the elements included in the list
        /// </summary>
        private int count = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="List{ItemType}"/> class.
        /// </summary>
        public List()
        {
            elements = new ItemType[1];
        }

        /// <summary>
        /// Add a new item to the list.
        /// </summary>
        /// <param name="element">The element.</param>
        public void Add(ItemType element)
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
            ItemType[] newElements = new ItemType[2 * length];

            for (int i = 0; i < elements.Length; i++)
            {
                newElements[i] = elements[i];
            }
            elements = newElements;
        }

        /// <summary>
        /// Gets or sets the <see cref="`0"/> at the specified index.
        /// </summary>
        public ItemType this[int index]
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

    class TestListWithGenerics
    {
        # region Test code. Uncomment for testing

        //public static void Main()
        //{
        //    List<int> intList = new List<int>();

        //    intList.Add(1);           // No boxing
        //    intList.Add(2);           // No boxing
        //    // intList.Add("Three");     // Compile-time error

        //    int i = intList[0];       // No cast required

        //    for (int j = 0; j < intList.Length; j++)
        //    {
        //        Console.WriteLine(intList[j]);
        //    }

        //    Console.ReadLine();
        //}

        #endregion
    }
}
