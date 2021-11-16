using System;

namespace BaiTap3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao so A: ");
            float soA = Convert.ToSingle(Console.ReadLine());
            Console.Write("Nhap vao so B: ");
            float soB = Convert.ToSingle(Console.ReadLine());
            float soC = 0;
            soC = soA + soB;
            Console.Write("Tong cua " + soA + " va " + soB + " la " +soC);
            Console.ReadLine();
        }
    }
}
