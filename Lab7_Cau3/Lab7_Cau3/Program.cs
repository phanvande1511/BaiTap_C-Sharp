using System;

namespace Lab7_Cau3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Mark subject1 = new Mark();
            Mark subject2 = new Mark();
            Mark subject3 = new Mark();
            Mark subject4 = new Mark();
            Mark subject5 = new Mark();
            Mark subject6 = new Mark();
            Mark subject7 = new Mark();
            Mark subject8 = new Mark();

            print();

            int temp = 0;
            do
            {
                Console.WriteLine();
                Console.Write("You Can Choose From 1 To 4: ");
                temp = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (temp)
                {
                    case 1:
                        subject1.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject2.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject3.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject4.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject5.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject6.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject7.inPut();
                        Console.WriteLine("\n---------------------\n");
                        subject8.inPut();
                        break;
                    case 2:
                        menu();
                        line();
                        subject1.outPut();
                        subject2.outPut();
                        subject3.outPut();
                        subject4.outPut();
                        subject5.outPut();
                        subject6.outPut();
                        subject7.outPut();
                        subject8.outPut();
                        line();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine(" Highest GPA");
                        Console.WriteLine();
                        line();
                        if (subject1.mediumScore() > subject2.mediumScore() && subject1.mediumScore() > subject3.mediumScore() && subject1.mediumScore() > subject4.mediumScore() && subject1.mediumScore() > subject5.mediumScore() && subject1.mediumScore() > subject6.mediumScore() && subject1.mediumScore() > subject7.mediumScore() && subject1.mediumScore() > subject8.mediumScore())
                        {
                            subject1.outPut();
                        } else if (subject2.mediumScore() > subject1.mediumScore() && subject2.mediumScore() > subject3.mediumScore() && subject2.mediumScore() > subject4.mediumScore() && subject2.mediumScore() > subject5.mediumScore() && subject2.mediumScore() > subject6.mediumScore() && subject2.mediumScore() > subject7.mediumScore() && subject2.mediumScore() > subject8.mediumScore())
                        {
                            subject2.outPut();
                        } else if (subject3.mediumScore() > subject1.mediumScore() && subject3.mediumScore() > subject2.mediumScore() && subject3.mediumScore() > subject4.mediumScore() && subject3.mediumScore() > subject5.mediumScore() && subject3.mediumScore() > subject6.mediumScore() && subject3.mediumScore() > subject7.mediumScore() && subject3.mediumScore() > subject8.mediumScore())
                        {
                            subject3.outPut();
                        } else if (subject4.mediumScore() > subject1.mediumScore() && subject4.mediumScore() > subject2.mediumScore() && subject4.mediumScore() > subject3.mediumScore() && subject4.mediumScore() > subject5.mediumScore() && subject4.mediumScore() > subject6.mediumScore() && subject4.mediumScore() > subject7.mediumScore() && subject4.mediumScore() > subject8.mediumScore())
                        {
                            subject4.outPut();
                        } else if (subject5.mediumScore() > subject1.mediumScore() && subject5.mediumScore() > subject2.mediumScore() && subject5.mediumScore() > subject3.mediumScore() && subject5.mediumScore() > subject4.mediumScore() && subject5.mediumScore() > subject6.mediumScore() && subject5.mediumScore() > subject7.mediumScore() && subject5.mediumScore() > subject8.mediumScore())
                        {
                            subject5.outPut();
                        } else if (subject6.mediumScore() > subject1.mediumScore() && subject6.mediumScore() > subject2.mediumScore() && subject6.mediumScore() > subject3.mediumScore() && subject6.mediumScore() > subject4.mediumScore() && subject6.mediumScore() > subject5.mediumScore() && subject6.mediumScore() > subject7.mediumScore() && subject6.mediumScore() > subject8.mediumScore())
                        {
                            subject6.outPut();
                        } else if (subject7.mediumScore() > subject1.mediumScore() && subject7.mediumScore() > subject2.mediumScore() && subject7.mediumScore() > subject3.mediumScore() && subject7.mediumScore() > subject4.mediumScore() && subject7.mediumScore() > subject5.mediumScore() && subject7.mediumScore() > subject6.mediumScore() && subject7.mediumScore() > subject8.mediumScore())
                        {
                            subject7.outPut();
                        } else
                        {
                            subject8.outPut();
                        }
                        line();
                        break;
                        Console.WriteLine();
                    case 4:
                        Console.WriteLine("Bye Bye =))");
                        break;
                    default: break;
                }
            } while (temp < 4 && temp >= 1); 
        }

        static void line()
        {
            for (int i = 0; i < 86; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }// duong ngan cach

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

        static void menu()// in bang thong tin
        {
            Console.WriteLine("MENU");
            line();
            String st = String.Format("|{0}|", centeredString(" Ordinal Number ", -20))
              + String.Format("{0}|", centeredString(" Subject Title ", -20))
              + String.Format("{0}|", centeredString(" Theoretical Score ", -20))
              + String.Format("{0}|", centeredString(" Practice Score ", -20))
              + String.Format("{0}|", centeredString(" Medium Score ", -20));

            Console.WriteLine(st);
        }

        static void print()
        {
            Console.WriteLine("1. Enter Subject Name");
            Console.WriteLine("2. Print Subject Name");
            Console.WriteLine("3. Highest GPA");
            Console.WriteLine("4. Exit");
            Console.WriteLine("---------------------");
        }
    }
}