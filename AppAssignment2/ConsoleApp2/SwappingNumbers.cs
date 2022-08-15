using System;

namespace ConsoleApp2
{
     class SwappingNumbers
    {
        int num1, num2, temp;

        public void Swap()
        {
            Console.WriteLine("\nInput the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nInput the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("\nAfter Swapping : ");
            Console.WriteLine("\nFirst Number : " + num1);
            Console.WriteLine("\nSecond Number : " + num2);
            Console.ReadLine();
        }
            public static void Main(string[] args)
        {
            try
            {
                SwappingNumbers obj = new SwappingNumbers();
                obj.Swap();
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some error occurred");
            }
            }
        }
    }

