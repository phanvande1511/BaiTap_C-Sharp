using System;

namespace Lab3_Cau3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            Console.Write("Quantity: ");
            int n = System.Int32.Parse(Console.ReadLine());
            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Number: ");
                temp[i] = System.Int32.Parse(Console.ReadLine());
            }

            max = temp[0];
            min = temp[0];

            for (int i = 0; i < n; i++)
            {
                if (temp[i] > max)
                {
                    max = temp[i];
                }
                if (temp[i] < min)
                {
                    min = temp[i];
                }
            }

            Console.WriteLine("Max = {0}.", max);
            Console.WriteLine("Min = {0}.", min);
        }
    }
}
