using System;

namespace InterviewQuestions
{
    class Program
    {
        public static void LargestSmallest (int[] nums)
        {
            int min, max;
            min = nums[0];
            max = nums[0];

            for (var i=1; i<nums.Length;i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
        }
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 35, 6, 7, 8, 44, 66, 3, 9, -7 };

            LargestSmallest(numbers);
        }
    }
}
