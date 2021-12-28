using System;
namespace Lab9_Cau4
{
    public class Student
    {
        private int studentCode;
        private string name;
        private int age;
        private double mediumPoint;

        public Student(string name, int studentCode , int age, double mediumPoint)
        {
            this.studentCode =  studentCode;
            this.name = name;
            this.age = age;
            this.mediumPoint = mediumPoint;
        } 

        public void information()
        {
            Console.WriteLine("Ten Sv: {0}", name);
            Console.WriteLine("Ma Sv: {0}", studentCode);
            Console.WriteLine("Tuoi: {0}", age);
            Console.WriteLine("DTB: {0}", mediumPoint);
        }

        public void infor()
        {
            Console.WriteLine("Ten Sv: {0}", name);
            Console.WriteLine("DTB: {0}", mediumPoint);
        }

        public void test()
        {
            if (mediumPoint >= 8)
            {
                Console.WriteLine("Du dieu kien nhan hoc bong");
            } else
            {
                Console.WriteLine("Khong du dieu kien nhan hoc bong");
            }
        }

        public string getName()
        {
            return name;
        }

        public double getMark()
        {
            return mediumPoint;
        }

        public void setMark(double Mark)
        {
            this.mediumPoint = Mark;
        }

        public void sort()
        {
            Console.WriteLine();
            Console.Write("Ten Sv: {0}     ", name);
            Console.Write("DTB: {0}", mediumPoint);
            Console.WriteLine();
        }
    }
}