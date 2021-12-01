using System;

namespace Ham_Bai115
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Information();
            Console.WriteLine("Diem TB cua mon Toan va mon Van la: {0}", Average());
        }

        static void Information()
        {
            Console.Write("Nhap ho ten cua ban: ");
            string name = Console.ReadLine();
        }

        static float Average()
        {
            Console.Write("Nhap diem toan cua ban: ");
            float dToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem van cua ban: ");
            float dVan = float.Parse(Console.ReadLine());
            float average = (dToan + dVan) / 2;
            return average;
        }
    }
}
