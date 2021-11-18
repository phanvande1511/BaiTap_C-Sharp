using System;

namespace Lab3_Cau4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap canh a: ");
            int a = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap canh b: ");
            int b = System.Int32.Parse(Console.ReadLine());
            Console.Write("Nhap canh c: ");
            int c = System.Int32.Parse(Console.ReadLine());

            Console.WriteLine("------------");

            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Day khong phai la hinh tam giac");
            } else if (Math.Abs(a - b) < c && Math.Abs(a - c) < b && Math.Abs(c - b) < a)
            {
                Console.WriteLine("Day la hinh tam giac");
            } else
            {
                Console.WriteLine("Day khong phai la hinh tam giac");
            }
        }
    }
}
