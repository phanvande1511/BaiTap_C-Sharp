using System;

namespace Lab3_Cau1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Number A: ");
            int numberA = System.Int32.Parse(Console.ReadLine());
            Console.Write("Enter Number B: ");
            int numberB = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            if (numberB <= 0)
            {
                Console.WriteLine("Error!!!");
            } else
            {
                Console.Write(numberA + " / " + numberB + " = " + (numberA / numberB));
            }
        }
    }
}
