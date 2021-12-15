using System;

namespace Lab7_Cau3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mark a = new Mark();
            a.inPut();
            line();
            a.outPut();
        }

        static void line()
        {
            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
