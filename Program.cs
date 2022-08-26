using Nager.Date;
using System;

namespace learn_data_structure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "abc", "aba", "ab" };

            for (int i = 0; i < inputArray.Length; i++)
            {
                int min_idx = i;

                for (int j = i+1; j < inputArray.Length; j++)
                {
                    if (inputArray[j].CompareTo(inputArray[min_idx])<0)
                    {
                        min_idx = j;
                    }
                }

               // if (min_idx != i) 
                { 
                string temp = inputArray[min_idx];
                inputArray[min_idx] = inputArray[i];
                inputArray[i] = temp;
                }
            }

        }

        //Console.WriteLine($"count of  even numbers: {evenLengthInteger}");

        //    int[] nums = new int[6] { 1, 1, 1, 0, 1, 1 };
        //    int counter = 0;
        //    int maxCount = 0;

        //    for (int j = 0; j < nums.Length; j++)
        //    {
        //        if (nums[j] == 1)
        //        {
        //            counter++;
        //            if (counter > maxCount) maxCount = counter;
        //        }
        //        else counter = 0;
        //    }
        //    Console.WriteLine($"counter: {maxCount} ");
        //Console.WriteLine($"length of the array: {nums.Length}");
        //Console.WriteLine($"capacity of the array: {nums.LongLength}");
        //Console.WriteLine($"Rank of the array: {nums.Rank}");

    }
    }
