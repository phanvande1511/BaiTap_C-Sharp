using System;

namespace Lab4_Cau6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap so Fabonacy ma ban can: ");
            int n = int.Parse(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            int fn;
            for (int i = 1; i <= n; i++)
            {
                if (i <= 1)
                {
                    fn = i;
                } else
                {
                    fn = f1 + f0;
                    f0 = f1;
                    f1 = fn;
                }
                Console.WriteLine("So Fabocany thu {0} la: {1}", i, fn);
            }
        }
    }
}
