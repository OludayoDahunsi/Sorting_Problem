//Written by Oludayo Dahunsi
//02/27/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Problem
{
    public class Sorter
    {
        private List<int> aList;

        public Sorter(List<int> aList)
        {
            this.aList = aList;
        }

        public List<int> BubbleSort()
        {
            for (int i = 0; i < aList.Count - 1; i++)
            {
                for (int j = 0; j < aList.Count - i - 1; j++)
                {
                    if (aList[j] > aList[j + 1])
                    {
                        int temp = aList[j];
                        aList[j] = aList[j + 1];
                        aList[j + 1] = temp;
                    }
                }
            }
            return aList;
        }

        public List<int> SelectionSort()
        {
            for (int i = 0; i < aList.Count - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < aList.Count; j++)
                {
                    if (aList[j] < aList[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = aList[i];
                aList[i] = aList[minIndex];
                aList[minIndex] = temp;
            }
            return aList;
        }

        public List<int> InsertionSort()
        {
            for (int i = 1; i < aList.Count; i++)
            {
                int key = aList[i];
                int j = i - 1;
                while (j >= 0 && aList[j] > key)
                {
                    aList[j + 1] = aList[j];
                    j--;
                }
                aList[j + 1] = key;
            }
            return aList;
        }
    }
}
