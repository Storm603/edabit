using System;
using System.Linq;

namespace T02._Multiply_by_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();


            Console.WriteLine(string.Join(", ", MultiplyByLength(arr)));
        }

        public static int[] MultiplyByLength(int[] arr)
        {
            int[] upped = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                upped[i] = arr[i] * arr.Length;
            }

            return upped;
        }
    }
}
