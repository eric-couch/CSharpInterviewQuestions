using System;

namespace InterviewQuestions
{
    class Program
    {
        public static void LargestSmallest(int[] nums)
        {
            int min, max, sum;
            min = nums[0];
            max = nums[0];
            sum = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                sum += nums[i];
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
            Console.WriteLine("avg = " + sum / nums.Length);
        }
        public static void SecondLargestSmallest(int[] nums)
        {
            int min, max, secondmin, secondmax;
            min = nums[0];
            secondmin = nums[0];
            max = nums[0];
            secondmax = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    secondmax = max;
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    secondmin = min;
                    min = nums[i];
                }
            }
            Console.WriteLine("second max = " + secondmax);
            Console.WriteLine("second min = " + secondmin);
        }

        public static string FindLongestWord(string para)
        {
            String longestWord = "";
            String[] words = para.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }
            return longestWord;
        }

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
                    if (h==1 || h==length || v == 1 || v == length)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        
        public static String ReturnSquare(int length)
        {

            String square = "";
            for (int h = 1; h <= length; h++)
            {
                for (int v = 1; v <= length; v++)
                {
                    if (h == 1 || h == length || v ==1 || v == length)
                    {
                        square += "*";
                    }
                    else
                    {
                        square += " ";
                    }
                }
                square += "\n";
            }
            return square;
        }
        public static String ReturnSquareSimple(int length)
        {
            String square = new String('*', length) + "\n";
            for (int h = 1; h <= length-2; h++)
            {
                square += "*" + new String(' ', length - 2) + "*\n";
            }
            square += new String('*', length);
            return square;
        }
        public static void PrintTree(int height)
        {
            // from one to height, that's the number of lines = height
            for (var h=1;h<height-1;h++)
            {
                //   *
                //  ***
                // *****
                //*******
                // first inner loop is spaces
                // how many spaces line one?  Three, so start at zero
                // w=0, go to (4-1)=3, 3-2=1

                for (var w=0;w<(height-h)-2;w++)
                {
                    Console.Write(" ");
                }

                // second loop is *
                for (var w=0;w<(h*2)-1;w++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static String GetInitials(string fullName)
        {
            String initials = "";
            for (int n=0;n< fullName.Split(' ').Length;n++)
            {
                initials += fullName.Split(' ')[n][0] + " ";
            }
            return initials;
            
        }
        public static String ReverseString (String str)
        {
            String rev = "";
            for (int i= str.Length-1; i>=0;i--)
            {
                rev += str[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {

            int[] numbers = { 0, 1, 2, 35, 6, 7, 8, 44, 66, 3, 9, -7 };

            LargestSmallest(numbers);

            SecondLargestSmallest(numbers);

            String testString = "Now is the time for all good men to come to the aid of their country.";
            Console.WriteLine(FindLongestWord(testString));

            PrintSquare(15);

            Console.WriteLine(ReturnSquare(10));

            Console.WriteLine(ReturnSquareSimple(10));

            PrintTree(16);

            Console.WriteLine(GetInitials("James Eric Couch"));

            Console.WriteLine(ReverseString("James Eric Couch"));
        }
    }
}
