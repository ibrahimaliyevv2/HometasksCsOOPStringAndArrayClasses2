using System;
namespace ClassroomData
{
    public class Student
    {
        public Student(string fullName)
        {
            this.FullName = fullName;
        }

        public string FullName;
        public string GroupNo;
        public double AvgPoint;
    }
}
