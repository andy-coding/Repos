using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> StringList = new List<string>();


            for (int i = 7; i > -1; i--)
            {
                StringList.Add("string"+i);
            }

            StringList.Add("removeme");
            StringList.Add("removeme");
            StringList.Add("removeme");


            for (int i = 0; i<StringList.Count; i++)
            {
                Console.WriteLine("List Integers values are {0}", StringList[i]);
            }

            DisplayList(StringList);

            Console.WriteLine("List is of size {0}", StringList.Count);

            StringList.Sort();
            foreach (string stringEntry in StringList)
            {
                Console.WriteLine("Sorted list value: {0}", stringEntry);
            }

            RemoveSingleEntry(StringList, "removeme");
            DisplayList(StringList);

            Console.WriteLine("Now removing all remaining remove entries...");

            RemoveAllEntries(StringList, "removeme");
            DisplayList(StringList);


            Console.ReadLine();




            void DisplayList(List<string> listName)
            {
                foreach (string stringEntry in StringList)
                {
                    Console.WriteLine("value: {0}", stringEntry);
                }
            }

            void RemoveSingleEntry(List<string> list, string entry)
            {
                Console.WriteLine("Removing entry {0}...", entry);
                list.Remove(entry);
            }

            void RemoveAllEntries(List<string> list, string entry)
            {
                Console.WriteLine("Removing entry {0}...", entry);

                while (list.Contains(entry))
                {
                    list.Remove(entry);
                }
            }

        }
    }
}
