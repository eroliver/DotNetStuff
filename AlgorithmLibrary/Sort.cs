using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AlgorithmLibrary
{
    public class Sort
    {
        public int SmallestValue(List<string> stringList)
        {
            string smallestValue = null;
            int smallestIndex = 0;

            foreach(int index in Enumerable.Range(0, (stringList.Count - 1)))
            {
                if(String.Compare(stringList[index], smallestValue) < 0)
                {
                    smallestValue = stringList[index];
                    smallestIndex = index;
                }
            }

            return smallestIndex;
        }
        public List<string> SelectionSort(List<string> unsortedList)
        {
            List<string> sortedList = new List<string>();

            foreach(int index in Enumerable.Range(0, (unsortedList.Count)))
            {
                int smallest = SmallestValue(unsortedList);
                sortedList.Add(unsortedList[smallest]);
                unsortedList.RemoveAt(smallest);
            }

            return sortedList;
        }
    }
}
