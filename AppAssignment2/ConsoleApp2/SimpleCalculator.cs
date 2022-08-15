using System;

namespace ConsoleApp2
{
    
      class SimpleCalculator
    {
        public static void Main()
        {
            try
            {
                int num1, num2, select;
                Console.WriteLine("Enter First No :");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second No :");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n1-Addition.\n2-Subtraction.\n3-Multiplication.\n4-Division.\n");
                Console.WriteLine("\nSelect your Option");
                select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, num1 + num2);
                        break;


                    case 2:
                        Console.WriteLine("Subtraction of {0} and {1} is {2}", num1, num2, num1 - num2);
                        break;


                    case 3:
                        Console.WriteLine("Multiplication of {0} and {1} is {2}", num1, num2, num1 * num2);
                        break;


                    case 4:
                        Console.WriteLine("Division of {0} and {1} is {2}", num1, num2, num1 / num2);
                        break;


                    default:
                        Console.WriteLine("Some Error Occurred");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred");
            }
            }
        }
    }

