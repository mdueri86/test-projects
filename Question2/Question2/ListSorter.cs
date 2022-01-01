using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    /// <summary>
    /// ListSorter Class - Has no public methods. The client code calls the constructor to input the original unsorted list and the class does the work.  
    /// I use generics so that any type of list can be passed into the class. In this case, I am testing with ints and strings.
    /// </summary>
    public class ListSorter<T>
    {
        private List<T> SortedList = new List<T>();
        private List<T> DistinctSortedList = new List<T>();                
        private readonly List<ValueInfo<T>> ValueInfoList = new List<ValueInfo<T>>();

        public ListSorter(List<T> unsortedList)
        {            
            SortTheList(unsortedList);
            FillValueInfoList();            
        }
        
        /// <summary>
        /// This method will sort distinct values in a list
        /// </summary>
        /// <param name="unsortedList"></param>
        private void SortTheList(List<T> unsortedList)
        {
            unsortedList.Sort();
            SortedList = unsortedList; // make a copy to use for the fill list comparison so I don't have to sort again.
            DistinctSortedList = unsortedList.Distinct().ToList();            
        }


        /// <summary>
        /// This method will count each distinct value in the sorted list and put the results in the ValueInfo class
        /// It may seem inefficient to create a class for each returned value, I'm assuming a real world situation where return class message objects are common.
        /// </summary>
        private void FillValueInfoList ()
        {
            // compare distinct list with sorted list.
            foreach (T val in DistinctSortedList)
            {
                ValueInfo<T> valueInfo = new ValueInfo<T>();
                valueInfo.UniqueValue = val;
                valueInfo.Count = SortedList.Count(x => x.Equals(val));                
                ValueInfoList.Add(valueInfo);                
            }
        }
    }
}
