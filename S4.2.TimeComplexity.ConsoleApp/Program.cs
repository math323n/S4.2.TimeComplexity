using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TimeComplexity
{
    class Program
    {
        static void Main()
        {
            //Change array element counts when you want to check big O
            int[] array = new int[100000];
            int[] array2 = new int[100000];
            Sum(array);
            Find(array, 2);
            Contains(array, 5);
            Remove(array, 3);
            RemoveByValue(array, 3);
            Matching(array, array2);
            Factorial(7000);
            Sort(array);
            Console.ReadLine();
        }

        //Sum: O(n)
        private static int Sum(int[] array)
        {
            int total = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();

            foreach(int i in array)
            {
                total += i;
            }

            timer.Stop();
            Console.WriteLine($"Sum: {timer.ElapsedTicks}");
            timer.Reset();
            return total;
        }

        //Find: 0(1)
        private static int Find(int[] array, int index)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            int value = array[index];

            timer.Stop();
            Console.WriteLine($"Find: {timer.ElapsedTicks}");
            timer.Reset();
            return value;
        }

        //Contains: O(n)
        private static bool Contains(int[] array, int value)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            foreach(int i in array)
            {
                if(i == value)
                {
                    timer.Stop();
                    Console.WriteLine($"Contains: {timer.ElapsedTicks}");
                    timer.Reset();
                    return true;
                }
            }
            timer.Stop();
            Console.WriteLine($"Contains: {timer.ElapsedTicks}");
            timer.Reset();
            return false;
        }

        //Remove at: O(n)
        private static void Remove(int[] array, int index)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            array = array.Where(i => i != array[index]).ToArray();
            timer.Stop();
            Console.WriteLine($"Remove: {timer.ElapsedTicks}");
            timer.Reset();
        }

        //Remove by value: O(n2)
        private static void RemoveByValue(int[] array, int value)
        {
            int n = 0;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    n++;
                }
            }

            int[] newArray = new int[n];
            int j = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] != 0)
                {
                    newArray[j] = array[i];
                    j++;
                }
            }
            timer.Stop();
            Console.WriteLine($"Remove by value: {timer.ElapsedTicks}");
            timer.Reset();
        }

        //Matching: O(n2) 
        private static List<long> Matching(int[] array, int[] array2)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            List<long> matchingElements = new();
            foreach(int i in array)
            {
                foreach(int n in array2)
                {
                    if(i == n)
                    {
                        matchingElements.Add(i);
                    }

                }
            }
            timer.Stop();
            Console.WriteLine($"Matching: {timer.ElapsedTicks}");
            timer.Reset();
            return matchingElements;
        }

        //Factorial: O(n2) FORKERT: O(1)
        private static int Factorial(int n)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            if(n == 0)
            {
                timer.Stop();
                Console.WriteLine($"Factorial: {timer.ElapsedTicks}");
                timer.Reset();
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        //Sort: O(n)
        private static void Sort(int[] array)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for(int i = 0; i < array.Length - 2; i++)
            {
                if(array[i] > array[i + 1])
                {
                    Swap(array[i], array[i + 1]);
                }
            }
            timer.Stop();
            Console.WriteLine($"Sort: {timer.ElapsedTicks}");
            timer.Reset();
        }

        //Swap: O(1)
        private static int[] Swap(int value, int otherValue)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            int[] swappedArray = { otherValue, value };
            timer.Stop();
            Console.WriteLine($"Swap: {timer.ElapsedTicks}");
            timer.Reset();
            return swappedArray;
        }
    }
}