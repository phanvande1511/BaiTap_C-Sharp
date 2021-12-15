using System;
namespace Lab7_Cau3
{
    public class Mark
    {
        private int ordinalNumber;// so thu tu
        private string subjectTitle;//ten mon hoc
        private float theoreticalScore;//diem ly thuyet
        private float practiceScore;//diem thuc hanh

        public float mediumScore()
        {
            return (theoreticalScore + practiceScore) / 2;
        }

        public void inPut()// nhap thong tin
        {
            Console.Write("- Ordinal Number: ");
            ordinalNumber = int.Parse(Console.ReadLine());
            Console.Write("- Subject Title: ");
            subjectTitle = Console.ReadLine();
            Console.Write("- Theoretical Score: ");
            theoreticalScore = float.Parse(Console.ReadLine());
            Console.Write("- Practice Score: ");
            practiceScore = float.Parse(Console.ReadLine());
        }

        public void outPut()// xuat thong tin
        {
            String st = String.Format("| {0} |", centeredString($"{ordinalNumber}", 14))
          + String.Format("{0}|", centeredString($"{subjectTitle}", 15))
          + String.Format("{0}|", centeredString($"{theoreticalScore}", 19))
          + String.Format("{0}|", centeredString($"{practiceScore}", 16))
          + String.Format("{0}|", centeredString($"{mediumScore()}", 14));

            Console.WriteLine(st);
        }

        static string centeredString(string s, int width)
        {
            if (s.Length >= width)
            {
                return s;
            }

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }// ham cach deu
    }
}
