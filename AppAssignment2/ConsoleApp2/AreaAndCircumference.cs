using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class AreaAndCircumference
    {
        int radius;

        public void Circle()
        {
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area of Circle {0} is {1}", radius, 3.14 * radius * radius);
            Console.WriteLine("Circumference of Circle {0} is {1}", radius, 2 * 3.14 * radius);

        }
        public static void Main()
        {
            try
            {
                AreaAndCircumference obj = new AreaAndCircumference();
                obj.Circle();
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Some error occurred");
            }
        }
    }

}
