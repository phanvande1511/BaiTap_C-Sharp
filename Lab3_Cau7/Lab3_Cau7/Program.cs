using System;

namespace Lab3_Cau7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\tMENU");
            Console.WriteLine("--------------------");
            Console.WriteLine("1. CF");
            Console.WriteLine("2. C");
            Console.WriteLine("3. HDJ");
            Console.WriteLine("4. DreanWeaver");
            Console.WriteLine("5. RDBMS");
            Console.WriteLine("6. Learn Java By Example");
            Console.WriteLine("--------------------");

            Console.Write("Chon: ");
            int n = System.Int32.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Ban chon: CF");
                    break;
                case 2:
                    Console.WriteLine("Ban chon: C");
                    break;
                case 3:
                    Console.WriteLine("Ban chon: HDJ");
                    break;
                case 4:
                    Console.WriteLine("Ban chon: DreanWeaver");
                    break;
                case 5:
                    Console.WriteLine("Ban chon: RDBMS");
                    break;
                case 6:
                    Console.WriteLine("Ban chon: Learn Java By Example");
                    break;
                default:
                    Console.WriteLine("Chon sai so roi do");
                    break;
            }
        }
    }
}
