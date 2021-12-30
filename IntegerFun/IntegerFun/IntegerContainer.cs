using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerFun
{
    public class IntegerContainer
    {
        
        private int[] intArray;

        // constructor 1 - input how many in array        
        public IntegerContainer(int fillCount)
        {
            // check the size of array requested. Make it fit regardless of what they enter.
            // the other more probable option is to throw an exception
            if (fillCount < 1) fillCount = 1;
            if (fillCount > 100) fillCount = 100;
            
            intArray = new int[fillCount];

            /* Fill a test array
            Random random = new Random();
            for (int i=0; i<fillCount; i++)
            {                 
                intArray[i] = random.Next(1,100);
            }
            */
        }

        // copy constructor
        public IntegerContainer(IntegerContainer ic)
            :this(ic.intArray.Length)
        {               
            Array.Copy(ic.intArray, intArray, ic.intArray.Length);
        }

        public void SetIndexValue(int index, int value)
        {
            try
            {
                intArray[index] = value;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Sorry {value} is not a valid input parameter");
            }
        }

        public int GetIndexValue(int index)
        {
            try
            {
                return intArray[index];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public string GetStringIndexValue(int index)
        {       
            try
            {
                return GetIndexValue(index).ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

        public bool ValueExists(int value)
        {
            int index = Array.IndexOf(intArray, value);
            try
            {
                if (index > -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
