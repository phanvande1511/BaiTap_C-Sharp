using System;

namespace Lab4_Cau3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            int soA = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int soB = int.Parse(Console.ReadLine());
            int max;
            int min;
            if (soA > soB)
            {
                max = soA;
                min = soB;
            } else
            {
                max = soB;
                min = soA;
            }
            Console.WriteLine("======================");
       
            if (soA > 0 && soB > 0)
            {
                Console.Write("Cac so chia het cho 7: ");
                for (int i = min; i <= max; i++)
                {
                    if (i % 7 == 0)
                    {
                        Console.Write(" " + i);
                    }
                }
            } else
            {
                Console.WriteLine("Loi!!!");
            }
            
        }
    }
}
