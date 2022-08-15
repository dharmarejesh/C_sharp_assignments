using System;

namespace ConsoleApp3
{
     class Multiply
    {
        public static void Main(string[] args)
        {
            int a, b, c, res;
            Console.WriteLine("Enter First No:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third No:");
            c = Convert.ToInt32(Console.ReadLine());
            res = a * b * c;
            Console.WriteLine("Result:{0}*{1}*{2}={3}",a,b,c,res);
           
        }
    }
}
