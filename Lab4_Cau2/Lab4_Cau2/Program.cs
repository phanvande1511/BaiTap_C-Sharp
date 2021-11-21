using System;

namespace Lab4_Cau2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tBat Dau");
            Console.WriteLine("=======================");
            Console.Write("Nhap vao 1 ki tu khac Space de bat dau: ");
            char temp = char.Parse(Console.ReadLine());
            
            while (temp != ' ')
            {
                Console.Write("\nNhap vao 1 ki tu bat ki: ");
                char kitu = char.Parse(Console.ReadLine());
                byte ascii = (byte)kitu;

                if (kitu <= 57 && kitu >= 48)
                {
                    Console.Write("\n-Day la chu so\n");                 
                }
                else if ((ascii >= 33 && ascii <= 47) || (ascii >= 58 && ascii <= 64) || (ascii >= 91 && ascii <= 96) || (ascii >= 123 && ascii <= 127))
                {
                    Console.Write("\n-Day la ki tu dac biet\n");
                }
                else if (ascii >= 65 && ascii <= 90 || ascii >= 97 && ascii <= 122)
                {
                    Console.Write("\n-Day la chu cai\n");
                }
                else
                {
                    Console.Write("\n- Nhap sai roi!!!\n");
                    break;
                }
            }
        }
    }
}
