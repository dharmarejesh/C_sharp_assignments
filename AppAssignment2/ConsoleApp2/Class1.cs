using System;
public class ArmstrongExample
{
    public static void Main(string[] args)
    {
        try {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Armstrong Number.");
            else
                Console.WriteLine("Not Armstrong Number.");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Some error occurred'");
        }
    }
}