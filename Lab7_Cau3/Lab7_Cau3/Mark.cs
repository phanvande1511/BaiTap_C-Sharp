using System;
namespace Lab7_Cau3
{
    public class Mark
    {
        private string subjectTitle;//ten mon hoc
        private float theoreticalScore;//diem ly thuyet
        private float practiceScore;//diem thuc hanh

        public float mediumScore()
        {
            return (theoreticalScore + practiceScore) / 2;
        }

        //public Mark(string subjectTitle, float theoreticalScore, float practiceScore)
        //{
        //    this.subjectTitle = subjectTitle;
        //    this.theoreticalScore = theoreticalScore;
        //    this.practiceScore = practiceScore;
        //}


        public void inPut()
        {
            Console.Write("- Subject Title: ");
            subjectTitle = Console.ReadLine();
            Console.Write("- Theoretical Score: ");
            theoreticalScore = float.Parse(Console.ReadLine());
            Console.Write("- Practice Score: ");
            practiceScore = float.Parse(Console.ReadLine());
        }

        public void outPut()
        {
            Console.WriteLine("- Subject Title: {0}", subjectTitle);
            Console.WriteLine("- Theoretical Score: {0}", theoreticalScore);
            Console.WriteLine("- Practice Score: {0}", practiceScore);
            Console.WriteLine("- Medium Score: {0}", mediumScore());
        }
    }
}
