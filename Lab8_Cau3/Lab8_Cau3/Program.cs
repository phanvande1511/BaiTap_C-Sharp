using System;

namespace Lab8_Cau3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            char[] temp;
            int count = 0;
            string chuoi;
            Console.Write("Nhap vao 1 chuoi: ");
            chuoi = Console.ReadLine();
            temp = chuoi.ToCharArray();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != temp[temp.Length - 1 - i])
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Day la chuoi doi xung");
            }
            else
            {
                Console.WriteLine("Day khong phai la chuoi doi xung");
            }
        }
    }
}