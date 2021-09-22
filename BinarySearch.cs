using System;

namespace Variables
{
    class Program{
        static void Main(string[] args)
        {
            int[] arr = {-1, 0, 3, 5, 9, 12};
            int target = 2;
            Solution solution = new Solution();
            int result=solution.Search(arr, target);
            Console.WriteLine(result);
        }
    }
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            var Low = 0;
            var High = nums.Length - 1;

            while (Low <= High)
            {
                var mid = (Low + High) / 2;

                if (nums[mid] == target)
                    return mid;
                if (nums[mid] < target)
                    Low = mid + 1;
                else
                    High = mid - 1;
            }
            return -1;
        }

    }
}
