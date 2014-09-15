using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Web.UI.WebControls;

namespace Es.Udc.DotNet.CSharpTutorial
{
    /// <summary>
    /// Using collections: Hashtable and ArrayList example
    /// </summary>
    class Languages
    {
        private static readonly Hashtable LANGUAGES = new Hashtable();
        private static readonly ArrayList LANGUAGES_en = new ArrayList();
        private static readonly ArrayList LANGUAGES_es = new ArrayList();

        /// <summary>
        /// Initializes the <see cref="Languages"/> class by means a hashtable.
        /// </summary>
        static Languages()
        {
            // ArrayLists stores the ListBox information
            LANGUAGES_en.Add(new ListItem("English", "en"));
            LANGUAGES_en.Add(new ListItem("Spanish", "es"));

            LANGUAGES_es.Add(new ListItem("Inglés", "en"));
            LANGUAGES_es.Add(new ListItem("Español", "es"));

            //Key: "en"    Value: ArrayList with english information
            LANGUAGES.Add("en", LANGUAGES_en);

            //Key: "es"    Value: ArrayList with spanish information
            LANGUAGES.Add("es", LANGUAGES_es);
        }

        #region  Test code. Uncomment for testing

        //public static void Main()
        //{
        //    Languages langs = new Languages();

        //    IEnumerator hashtableEnum = LANGUAGES.GetEnumerator();

        //    Console.WriteLine("Content of the LANGUAGES Hashtable:\n");

        //    while (hashtableEnum.MoveNext())
        //    {
        //        DictionaryEntry entry = (DictionaryEntry)hashtableEnum.Current;
        //        Console.WriteLine("\n Key: " + entry.Key + "\n Value: " +
        //            entry.Value + ":");

        //        ArrayList current = (ArrayList)entry.Value;

        //        IEnumerator arrayListEnum = current.GetEnumerator();

        //        while (arrayListEnum.MoveNext())
        //        {
        //            ListItem item = (ListItem)arrayListEnum.Current;
        //            Console.WriteLine("     " + item.Value + " - " + item.Text);
        //        }
        //    }

        //    Console.ReadLine();
        //}

        #endregion
    }
}
