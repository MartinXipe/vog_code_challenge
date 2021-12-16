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

        public static object TESTModule(object item)
        {

            switch (item.GetType())
            {
                case Type intType when intType == typeof(int):
                    int numericItem = (int)item;
                    if (numericItem > 0 && numericItem < 5)
                        return numericItem * 2;
                    if (numericItem > 4)
                        return numericItem * 3;
                    if (numericItem < 1)
                        throw new Exception("Error, the value is lower than 1.");
                    break;
                case Type floatType when floatType == typeof(float):
                    if ((float)item == 1.0f || (float)item == 2.0f)
                    {
                        return 3.0f;
                    }
                    break;
                case Type stirngType when stirngType == typeof(string):
                    return item.ToString().ToUpper();
                default:
                    return item;
            }

            return item;
        }

    }
}
