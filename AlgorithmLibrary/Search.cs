using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmLibrary
{
    public class Search
    {
        public int BinarySearch(List<string> searchList, string targetItem)
        {
            //ensure that types are correctly passed
            int lowestIndex = 0;
            int highestIndex = searchList.Count - 1;

            while(lowestIndex <= highestIndex)
            {
                int mid = (lowestIndex + highestIndex) / 2;
                string guess = searchList[mid];
                if(guess == targetItem)
                {
                    return mid;
                }
                if(String.Compare(guess, targetItem) > 0)
                {
                    highestIndex = mid - 1;
                }
                else
                {
                    lowestIndex = mid - 1;
                }
                return -1;
            }
            //catch this error, should only occor if an empty list is passed.
            return -1;
        }
    }

}
