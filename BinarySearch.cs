using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = BinarySearch(new List<int> { 1,2,3,4,5,6,7,8},6);
            Console.WriteLine(result);
            
            
        }
        public static int BinarySearch(List<int> list,int target)
        {
            int low = 0;
            int high = list.Count - 1;
            
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];
                if (target == guess) { return mid; }
                else if (target > guess) { low = mid + 1; }
                else { high = mid - 1; }
            }
            return 0;
        }

        
    }
}
