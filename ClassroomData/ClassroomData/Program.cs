using System;

namespace ClassroomData
{
    class Program
    {
        static void Main(string[] args)
        {
            string no;
            int studentLimit;
            bool check = true;

            Console.WriteLine("====================================================================================");

            do
            {
                Console.WriteLine("Please enter group number: (It should contain 2 uppercase letter and 3 digits!))");
                no = Console.ReadLine();
            } while (!(no.Length == 5 && char.IsUpper(no[0]) && char.IsUpper(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]) && char.IsDigit(no[4])));

            do
            {
                Console.WriteLine("Please enter student limit: (Limit can not be less than zero or greater than 20!)");
                studentLimit = Convert.ToInt32(Console.ReadLine());
            } while (studentLimit >= 20 || studentLimit <= 0);


            Group group = new Group();
            group.Students = new Student[studentLimit];

            while (check)
            {
                Console.WriteLine("=========================MENU======================");
                Console.WriteLine("Enter operation number(1, 2, 3 or 0) for each operation:");
                Console.WriteLine(" 1. Add student \n 2. Print all students \n 3. Search through students \n 0. Terminate program");
                Console.WriteLine("===================================================");
                int choose = Convert.ToInt32(Console.ReadLine());

                switch(choose)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("How many studets you want to add?");
                            int count = Convert.ToInt32(Console.ReadLine());
                            if (count + group.Count <= studentLimit)
                            {
                                for (int i = 0; i < count; i++)
                                {
                                    Console.WriteLine($"Enter fullname of {i+1}. student:");
                                    string fullname = Console.ReadLine();

                                    Console.WriteLine($"Enter average point of {i + 1}. student:");
                                    int avgPoint = Convert.ToInt32(Console.ReadLine());
                                    Student student = new Student(fullname)
                                    {
                                        AvgPoint = avgPoint,
                                        GroupNo = no
                                    };
                                    group.AddStudent(student);
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You have exceeded the limit.");
                                break;
                            }
                        }
                        break;

                    case 2:
                        foreach (var item in group.Students)
                        {
                            Console.WriteLine($"Full name: {item.FullName}, Group number: {item.GroupNo}, Average point: {item.AvgPoint}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter full name of student that you want to search:");
                        string fullName = Console.ReadLine();
                        group.FilterStudents(fullName);
                        break;

                    case 0:
                        check = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
