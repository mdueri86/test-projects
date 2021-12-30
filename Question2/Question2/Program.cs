using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main()
        {
            List<int> unsortedInts = new List<int>();
            List<string> unsortedStrings = new List<string>();

            // 4 ones, 1 two, 1 three, 2 fours, 2 fives, 1 six, 2 sevens, 0 eights, 1 nine
            unsortedInts.Add(5);
            unsortedInts.Add(4);
            unsortedInts.Add(5);
            unsortedInts.Add(1);
            unsortedInts.Add(7);
            unsortedInts.Add(1);
            unsortedInts.Add(6);
            unsortedInts.Add(7);
            unsortedInts.Add(9);
            unsortedInts.Add(2);
            unsortedInts.Add(3);
            unsortedInts.Add(1);
            unsortedInts.Add(1);
            unsortedInts.Add(4);


            // test with some strings. 3 test, 2 testing, 2 wow, 2 what, 1 this, 1 lone
            unsortedStrings.Add("test");
            unsortedStrings.Add("testing");
            unsortedStrings.Add("testing");
            unsortedStrings.Add("wow");
            unsortedStrings.Add("what");
            unsortedStrings.Add("what");
            unsortedStrings.Add("wow");
            unsortedStrings.Add("test");
            unsortedStrings.Add("this");
            unsortedStrings.Add("lone");
            unsortedStrings.Add("test");

            try
            {
                // try the generic method with ints
                ListSorter<int> listSorter = new ListSorter<int>(unsortedInts);

                // try the generic method with strings
                ListSorter<string> listSorter2 = new ListSorter<string>(unsortedStrings);
                
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

            
        }
    }
}
