using System;

namespace Lab8_Cau1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 chuoi bat ki: ");
            string chuoi = Console.ReadLine();
            Console.Write("Nhap vao 1 ki tu: ");
            string temp = Console.ReadLine();
            int dem = 0;

            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == temp[0])
                {
                    dem++;
                }
            }

            Console.WriteLine("So luong ki tu '{0}' trong chuoi la: {1}", temp[0], dem);
        }
    }
}
