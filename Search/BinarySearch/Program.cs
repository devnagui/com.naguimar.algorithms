using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 2, 3, 4, 5 };
            int target = 5;
            Console.WriteLine(Search(nums, target));
        }

        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            return BinarySearch(nums, target);
        }

        public static int BinarySearch(int[] nums, int target)
        {

            int pivot, left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                pivot = left + ((right - left) / 2);
                if (nums[pivot] == target)
                {
                    return pivot;
                }
                if (target < nums[pivot])
                {
                    right = pivot - 1;
                }
                else
                {
                    left = pivot + 1;
                }
            }
            return -1;
        }
    }
}
