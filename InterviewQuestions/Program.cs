using System;

namespace InterviewQuestions
{
    class Program
    {
        //  int width = 6
        // ******
        // *    *
        // *    *
        // *    *
        // *    *
        // ******
        public static void PrintSquare(int length)
        {
            for (int h=1; h<=length; h++)
            {
                for (int v=1; v<=length; v++)
                {
                    if (h==1 || h==length)
                    {
                        Console.Write("*");
                    } else 
                    {
                        if (v==1|| v==length)
                        {
                            Console.Write("*");
                        } else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

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

        // give a string, find the longet word in the string and return it
        public static string FindLongestWord(string para)
        {
            int longestWordLength = 0;
            String longestWord = "";
            String[] words = para.Split(" ");

            for (int i = 0; i<words.Length; i++)
            {
                if (words[i].Length > longestWordLength)
                {
                    longestWordLength = words[i].Length;
                    longestWord = words[i];
                } 
            }
            return longestWord;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 35, 6, 7, 8, 44, 66, 3, 9, -7 };

            LargestSmallest(numbers);

            PrintSquare(15);

            String testString = "Now is the time for all thisisatest good men to come to the aid of their country.";
            Console.WriteLine(FindLongestWord(testString));
        }
    }
}
