using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Params
    {

        static int Add(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        public static void Main(String[] args)
        {
            int[] arr = { 12, 3, 4, 15 };
         

            int n = arr.Length;
            Console.Write("Sum of given array is " + Add(arr));
        }
    }
}

