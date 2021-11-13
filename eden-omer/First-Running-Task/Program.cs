// Omer Kaplan, 208278036
// Eden Ezra, 318635372

using System;
using System.Collections.Generic;

namespace FirstRunningTask
{
    class Program
    {
        public static int sumIteratrionSearch1 = 0, sumIteratrionSearch2 = 0, sumIteratrionSearch3 = 0;
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            Random random = new Random();
            int zeroIndex = random.Next(150, 350);
            int arrayLen = 1000;

            for (int run = 0; run < 1000; run++)
            {
                Array.Clear(array, 0, arrayLen);

                for (int j = 0; j < zeroIndex; j++)
                {
                    array[j] = random.Next(1, 350);
                }

                Array.Sort(array, 0, zeroIndex);

                int x = random.Next(0, 370);

                Search1(array, arrayLen, x);
                Search2(array, arrayLen, x);
                Search3(array, arrayLen, x);

                zeroIndex = random.Next(150, 350);
            }

            Console.WriteLine("Average : \n");
            Console.WriteLine("Serach 1 : {0} = O(n) \n", sumIteratrionSearch1 /1000);
            Console.WriteLine("Serach 2 : {0} = O(log(m)) \n", sumIteratrionSearch2 / 1000);
            Console.WriteLine("Serach 3 : {0} = O(log(n)) \n", sumIteratrionSearch3 / 1000);


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
            return -1;
        }
        private static int Search2(int[] V, int m, int x)
        {
            int start = 0;
            int end = m - 1;

            while (start <= end)
            {
                sumIteratrionSearch2++;
                int mid = (start + end) / 2;
                if (V[mid] == x)
                    return mid;
                if (V[mid] == 0 || V[mid] > x)
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }
        private static int Search3(int[] V, int m, int x)
        {
            int start = 1;
            int end = m - 1;
            int nLen = 0;

            if (V[0] == 0)
                nLen = 0;

            while (start <= end)
            {
                sumIteratrionSearch3++;
                if (V[start] == 0)
                {
                    nLen = start;
                    break;
                }
                start *= 2;
            }

            if (start == end)
                nLen = m;

            int startN = 0;
            int endN = nLen - 1;

            while (startN <= endN)
            {
                sumIteratrionSearch3++;
                int mid = (startN + endN) / 2;
                if (V[mid] == x)
                    return mid;
                if (V[mid] > x)
                    endN = mid - 1;
                else
                    startN = mid + 1;
            }

            return -1;

        }
    }
}
