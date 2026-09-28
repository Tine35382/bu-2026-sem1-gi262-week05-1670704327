using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j; 
                    }
                }

                //int temp = numbers[minIndex];
                //numbers[minIndex] = numbers[i];
                //numbers[i] = temp;

                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        (numbers[j], numbers[j + 1]) = (numbers[j + 1], numbers[j]);
                    }
                }
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for(int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;
                while (numbers[j] > key && j >= 0)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            for (int i = 0; i < result.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] > result[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                (result[i], result[maxIndex]) = (result[maxIndex], result[i]);
            }
            return result;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        (result[j], result[j + 1]) = (result[j + 1], result[j]);
                    }
                }
            }
            return result;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();
            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;
                while (j >= 0 && result[j] < key)
                {
                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = key;
            }
            return result;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            if (numbers.Length == 0) return 0;

            int[] sorted = (int[])numbers.Clone();
            System.Array.Sort(sorted);
            System.Array.Reverse(sorted);
            
            int max = sorted[0];
            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] < max)
                {
                    return sorted[i];
                }
            }
            
            return 0; 
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0) return 0;
            
            int[] sorted = (int[])numbers.Clone();
            System.Array.Sort(sorted);
            
            int longest = 1;
            int currentStreak = 1;
            
            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] == sorted[i - 1] + 1)
                {
                    currentStreak++;
                }
                else if (sorted[i] != sorted[i - 1])
                {
                    longest = System.Math.Max(longest, currentStreak);
                    currentStreak = 1;
                }
            }
            
            return System.Math.Max(longest, currentStreak);
        }

        #endregion
    }
}