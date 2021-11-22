using System;

namespace BaiTap16
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                if (number == 0)
                {
                    Console.WriteLine("This is zero");
                } else if (number % 2 == 0)
                {
                    Console.WriteLine("This is even number");
                } else
                {
                    Console.WriteLine("This is odd number");
                }
            } else
            {
                Console.WriteLine("Error"); 
            }
        }
    }
}
