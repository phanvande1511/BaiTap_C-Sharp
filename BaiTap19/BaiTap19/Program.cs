using System;

namespace BaiTap19
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int min = 0;
            Console.Write("Enter number A: ");
            int numberA = int.Parse(Console.ReadLine());
            Console.Write("Enter number B: ");
            int numberB = int.Parse(Console.ReadLine());

            if (numberA > numberB)
            {
                min = numberB;
            }
            if (numberB > numberA)
            {
                min = numberA;
            }
            if (numberA == numberB)
            {
                min = numberB;
            }
            
            if (numberA > 0 && numberB > 0)
            {
                for (int i = min; i > 0; i--)
                {
                    if (numberA % i == 0 && numberB % i ==0)
                    {
                        Console.WriteLine("Greatest Common Divisor: {0}", i);
                        break;
                    }
                }
                
            } else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
