using System;
using System.Collections;

namespace Lab9_Cau4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student student = new Student("Nguyen Van A", 01234567, 18, 7.9);
            Student student1 = new Student("Nguyen Van B", 01234568, 19, 8);

            ArrayList studentList = new ArrayList();
            studentList.Add(student);
            studentList.Add(student1);

            int temp;

            infor();

            do
            {
                Console.Write("\nChon: ");
                temp = int.Parse(Console.ReadLine());

                switch(temp)
                {
                    case 1:
                        Console.WriteLine();
                        studentList.Add(student);
                        student.information();
                        break;
                    case 2:
                        Console.WriteLine();
                        studentList.Add(student1);
                        student1.information();
                        break;
                    case 3:
                        foreach (Student newstudent in studentList)
                        {
                            newstudent.information();
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        Console.Write("Nhap ten Sv muon tim: ");
                        string name = Console.ReadLine();
                        Console.WriteLine();
                        Student obj = null;

                        foreach (Student nameCheck in studentList)
                        {
                            if (name == nameCheck.getName())
                            {
                                obj = nameCheck;
                            }
                        }

                        if (obj != null)
                        {
                            obj.information();
                        }
                        else
                        {
                            Console.WriteLine("Khong co trong danh sach");
                        }

                        break;
                    case 5:
                        Console.Write("Nhap ten Sv muon tim: ");
                        string name1 = Console.ReadLine();
                        Console.WriteLine();
                        Student obj1 = null;
                        double obj2 = 0;

                        foreach (Student nameCheck in studentList)
                        {
                            if (name1 == nameCheck.getName())
                            {
                                obj1 = nameCheck;
                            }
                        }

                        if (obj1 != null)
                        {
                            Console.Write("Nhap diem muon sua: ");
                            double newMark = float.Parse(Console.ReadLine());
                            //
                            foreach (Student newMARK in studentList)
                            {
                                if (newMark != newMARK.getMark())
                                {
                                    obj2 = newMark;
                                }
                                if (obj2 != 0)
                                {
                                    obj1.setMark(obj2);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Khong co trong danh sach");
                        }
                        break;
                    case 6:
                        foreach (Student student3 in studentList)
                        {
                            student3.information();
                            student3.test();
                            Console.WriteLine();
                        }
                        break;
                    case 7:
                        foreach (Student student4 in studentList)
                        {
                            student4.infor();
                        }
                        break;
                    case 8:
                        if(student.getMark() > student1.getMark())
                        {
                            student.sort();
                            student1.sort();
                        }
                        if(student1.getMark() > student.getMark())
                        {
                            student1.sort();
                            student.sort();
                        }
                        break;
                    case 9:
                        if (student.getMark() == student1.getMark())
                        {
                            int temp2 = 0;

                            for (int i = student.getName().Length - 1; i >= 0; i--)
                            {
                                if (student.getName()[i] == 32)
                                {
                                    temp = i;
                                    break;
                                }
                            }

                            string strg = student.getName().Substring(temp + 1);

                            int temp1 = 0;

                            for (int i = student1.getName().Length - 1; i >= 0; i--)
                            {
                                if (student1.getName()[i] == 32)
                                {
                                    temp1 = i;
                                    break;
                                }
                            }

                            string strg1 = student1.getName().Substring(temp1 + 1);

                            if (((int)strg[0] < (int)strg1[0]))
                            {
                                Console.WriteLine(student.getName());
                                Console.WriteLine(student1.getName());
                            }
                            else
                            {
                                Console.WriteLine(student1.getName());
                                Console.WriteLine(student.getName());
                            }
                        } else
                        {
                            Console.WriteLine("Diem khong bang nhau");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Thoat");
                        break;
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
            } while (temp >= 1 && temp <= 9);
        }

        static void infor()
        {
            Console.WriteLine("Chuong trinh quan ly danh sach sinh vien su dung ArrayList");
            Console.WriteLine("==========================================================");
            Console.WriteLine("1. Khoi tao danh sach");
            Console.WriteLine("2. Them 1 sinh vien vao danh sach");
            Console.WriteLine("3. Duyet danh sach");
            Console.WriteLine("4. Tim thong tin sinh vien theo ten sinh vien");
            Console.WriteLine("5. Sua diem cho sinh vien");
            Console.WriteLine("6. Danh sach sinh vien duoc nhan hoc bong");
            Console.WriteLine("7. Xem diem cua sinh vien");
            Console.WriteLine("8. Sap xep danh sach giam dan theo DTB");
            Console.WriteLine("9. Sap xep danh sach giam dan theo DTB, tang dan theo ten");
            Console.WriteLine("0. Thoat");
        }
    }
}
