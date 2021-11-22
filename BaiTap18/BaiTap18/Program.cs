using System;

namespace BaiTap18
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int temp = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    temp++;
                }
            }
            if (temp == 2)
            {
                Console.WriteLine("That Is Prime Number");
            } else
            {
                Console.WriteLine("That Isn't Prime Number");
            }
        }
    }
}
