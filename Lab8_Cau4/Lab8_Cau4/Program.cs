using System;

namespace Lab8_Cau4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string chuoi;
            string temp = "";

            Console.Write("Nhap chuoi: ");
            chuoi = Console.ReadLine();

            chuoi = chuoi.Trim();

            while (chuoi.IndexOf("  ") != -1)// vi tri xuat hien 
            {
                chuoi = chuoi.Replace("  ", " ");// thay the
            }

            string[] SubName = chuoi.Split(' ');//tach chuoi thanh mang

            for (int i = 0; i < SubName.Length; i++)
            {
                string FirstChar = SubName[i].Substring(0, 1);
                string OtherChar = SubName[i].Substring(1);
                SubName[i] = FirstChar.ToUpper() + OtherChar.ToLower();
                temp += SubName[i] + " ";
            }
            var xoakitu = new string[] {"'", ",", "<", ".", ">", "/", "?", ";", ":", "|", "}", "]", "[", "{", "=", "+", "-", "_", ")", "(", "*", "&", "^", "%", "$", "#", "@", "!", "`", "~"};
            foreach (var a in xoakitu)
            {
                temp = temp.Replace(a, string.Empty);
            }

            Console.WriteLine("Ket Qua: " + temp);
        }
    }
} 