using System;

namespace Ham_Bai115
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap ho ten cua ban: ");
            string name = Console.ReadLine();
            Console.Write("Nhap diem toan cua ban: ");
            float dToan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem van cua ban: ");
            float dVan = float.Parse(Console.ReadLine());
            Console.WriteLine("Diem TB cua mon Toan va mon Van la: {0}", Average(dToan, dVan));
        }

        static float Average(float dToan, float dVan)
        {
            float average = (dToan + dVan) / 2;
            return average;
        }  
    }
}
