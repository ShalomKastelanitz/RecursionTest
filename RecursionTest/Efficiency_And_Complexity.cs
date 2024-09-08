using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTest
{
    internal class Efficiency_And_Complexity
    {
        //question1

        public static int CalculateOddSum(int[] array)//O(n)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        //question2

        public static (int, int) FindMaximumTwo(int[] array)//O(n)
        {
            int maxSum = int.MinValue;
            int num1 = 0, num2 = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int sum = array[i] + array[i + 1];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    num1 = array[i];
                    num2 = array[i + 1];
                }
            }

            return (num1, num2);
        }
        //question3

        public static bool ContainsNumber(int[] array, int number)// O(n)
        {
            foreach (int num in array)
            {
                if (num == number)
                {
                    return true;
                }
            }
            return false;
        }
        //question4

        public static int SumOfAllTriplets(int[] array)//O(n)
        {
            int maxSum = int.MinValue;

            for (int i = 0; i < array.Length - 2; i++)
            {
                int sum = array[i] + array[i + 1] + array[i + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }

            return maxSum;
        }
        //question5

        public static (int, int) FindLastPairWithProduct(int[] array, int product)//O(n)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] * array[i - 1] == product)
                {
                    return (array[i - 1], array[i]);
                }
            }

            return (-1, -1); // Indicate no pair was found
        }
        //question6
        public static int CountEvenNumbers(int[] array)
        {
            int count = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        //question8
        public static void FindPairsWithSum(int[] array, int sum)//O(n^2)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == sum)
                    {
                        Console.WriteLine($"Pair: ({array[i]}, {array[j]})");
                    }
                }
            }
        }

    }

}
