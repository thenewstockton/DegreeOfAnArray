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
                
                for (int i = 0; i <= a; i++)
                {
                    for (int j = nums.Length - 1; j >= b; j--)
                    {
                        int[] temp = ReturnSubArray(nums, i, j);
                        if (temp.Length < shortestSubArrayLength || shortestSubArrayLength == -1)
                        {
                            shortestSubArrayLength = temp.Length;
                        }
                    }
                }
            }
            
            return shortestSubArrayLength;
        }

        private int[] FindHighestFrequencyNumberOf(int[] nums)
        {
            var count = nums.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Count();
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
