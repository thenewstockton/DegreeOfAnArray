using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeOfAnArray
{
    public class Solution
    {
        public int FindShortestSubArray(int[] nums)
        {
            int shortestSubArrayLength = -1;
            var highestFrequencyNums = FindHighestFrequencyNumberOf(nums);
            foreach (var item in highestFrequencyNums)
            {
                int a = Array.IndexOf(nums, item);
                int b = Array.LastIndexOf(nums, item);
                int length = b - a + 1;
                if (length < shortestSubArrayLength || shortestSubArrayLength == -1)
                {
                    shortestSubArrayLength = length;
                }
            }
            
            return shortestSubArrayLength;
        }

        private int[] FindHighestFrequencyNumberOf(int[] nums)
        {
            var count = FindDegreeOf(nums);
            var a = nums.GroupBy(x => x).Where(x=> x.Count() == count).Select(x => x.Key).ToArray();
            return a;
        }

        private int FindDegreeOf(int[] nums)
        {
            return nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Count();
        }

        private int[] ReturnSubArray(int[] nums, int a, int b)
        {
            int length = b - a + 1;
            int[] temp = new int[length];
            Array.Copy(nums, a, temp, 0, length);
            return temp;
        }
    }
}
