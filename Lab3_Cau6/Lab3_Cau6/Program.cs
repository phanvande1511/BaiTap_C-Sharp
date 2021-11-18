using System;

namespace Lab3_Cau6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap vao 1 ki tu Alphabet: ");
            char kiTu = Convert.ToChar(Console.ReadLine());
            byte ascii = (byte)kiTu;
            
            if (ascii <= 90 && ascii >= 65 || ascii >= 97 && ascii <= 122)
            {
                Console.WriteLine("\nKi tu nay thuoc bang Alphabet");
                if (ascii == 65 || ascii == 97 || ascii == 69 || ascii == 101 || ascii == 79 || ascii == 111 || ascii == 73 || ascii == 105 || ascii == 85 || ascii == 117)
                {
                    Console.WriteLine("\nDay la nguyen am");
                } else
                {
                    Console.WriteLine("\nDay la phu am");
                }
            } else
            {
                Console.WriteLine("\nKi tu nay khong thuoc bang Alphabet");
            }

        }
    }
}
