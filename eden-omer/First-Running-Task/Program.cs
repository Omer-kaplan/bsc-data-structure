// submitted by
// Omer Kaplan, 208278036
// Eden Ezra, 

using System;
using System.Collections.Generic;

namespace FirstRunningTask
{
    class Program
    {
        private void generateArray() // Edit
        {
            //     int[] array = new int[1000];
            //     Random random = new Random();
            //     int zeroIndex = random.Next(350, 601);
            //     for (int run = 0; run < 1000; run++)
            //     {
            //         for (int j = 0; j < zeroIndex; j++)
            //         {
            //             array[] = random.Next(0, 100000);
            //         }
            //         array[run].sort((a, b) => a - b);
            //         array[run].fill(0, zeroIndex);
            //     }
            //     return arrays;
        }
        private static int Search1(int[] V, int m, int x)
        {
            for (int index = 0; index < m; index++)
            {
                sumIteratrionSearch1++;
                if (V[index] == x)
                    return index;
                else if (V[index] == 0)
                    break;
            }
            return 0;
        }
        private static int Search2(int[] V, int m, int x)
        {
            int start = 0;
            int end = m - 1;

            while (start <= end)
            {
                sumIteratrionSearch2++;
                int mid = Math.floor((start + end) / 2);
                if (V[mid] == x)
                    return mid;
                else if (V[mid] < x)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            return 0;
        }
        private static int Search3(int[] V, int m, int x)
        {
            return 0;
        }
        static void Main(string[] args)
        {
            // Sum vars decleration
            int sumIteratrionSearch1 = 0, sumIteratrionSearch2 = 0, sumIteratrionSearch3 = 0;

        }
    }
}
