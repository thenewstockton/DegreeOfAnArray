using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeOfAnArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.FindShortestSubArray(new int[] { 1, 2, 2, 2 }));
            Console.ReadLine();
        }
    }
}
