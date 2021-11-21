using System;

namespace Lab4_Cau5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 so nguyen bat ki: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = 0;
            while (n > 0)
            {
                temp = n % 10;
                n = n / 10;
                sum += temp;
            }
            Console.WriteLine("Tong cua so nguyen kia la : {0}", sum);
        }
    }
}
