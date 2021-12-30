using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    /// <summary>
    /// ListSorter Class - Has no public methods. Uses a constructor to input the original unsorted list and the class does the work.  
    /// Uses generics to that any type of list can be passed into the class.
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
        /// This method will count each distinct value in the sorted list.
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
