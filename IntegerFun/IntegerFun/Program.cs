using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFun
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerContainer ic = new IntegerContainer(104);

            int x = ic.GetIndexValue(2);
            
            ic.SetIndexValue(2, 6);

            if (ic.ValueExists(5))
            {
                Console.WriteLine("Value exists");
            }
            else
            {
                Console.WriteLine("Value does not exist");
            }

            // copy constructor 
            IntegerContainer ic2 = new IntegerContainer(ic);

            

        }
    }
}
