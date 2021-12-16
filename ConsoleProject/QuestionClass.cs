using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProject
{
    
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
         {
         "Jimmy",
         "Jeffrey",
         "John",
         };

        public static void GetNames()
        {
            var enumerator = NamesList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                string name = enumerator.Current;
                Console.WriteLine(name);
            }
        }

    }
}
