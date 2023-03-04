//Written by Oludayo Dahunsi
//02/27/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Problem
{
    public class Program
    {
        public static void Main()
        {
            List<int> myNumbers = new List<int>() { 5, 2, 7, 1, 8, 3 };
            Sorter mySorter = new Sorter(myNumbers);
            Console.WriteLine("Unsorted List: " + string.Join(", ", myNumbers));

            Console.WriteLine("Sorted using Bubble Sort: " + string.Join(", ", mySorter.BubbleSort()));
            Console.WriteLine("Sorted using Selection Sort: " + string.Join(", ", mySorter.SelectionSort()));
            Console.WriteLine("Sorted using Insertion Sort: " + string.Join(", ", mySorter.InsertionSort()));
        }
    }
}
