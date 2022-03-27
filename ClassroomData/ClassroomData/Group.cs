using System;
namespace ClassroomData
{
    public class Group
    {
        public string No;
        public Student[] Students;
        public int StudentLimit;
        public int Count = 0;
        public int CountOfFounded = 0;

        public void AddStudent(Student student)
        {
            Students[Count++] = student;
        }


        public void FilterStudents(string fullName)
        {
            foreach (var item in Students)
            {
                if (item.FullName == fullName) {
                    CountOfFounded++;
                    Console.WriteLine($"Full name: {item.FullName}, Group number: {item.GroupNo}, Average point: {item.AvgPoint}");
                }
            }
        }
    }
}
