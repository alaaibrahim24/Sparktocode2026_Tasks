using System;

namespace OOPPart1Solution
{
    internal class Student
    {
        public string Name;
        public int Id;
        public string Address;

        private int age;
        private double grade;

        // Read-only property
        public double Grade
        {
            get { return grade; }
        }

        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
        }

        public void UpdateGrade(double newGrade)
        {
            if (newGrade >= 0 && newGrade <= 100)
            {
                grade = newGrade;
            }
            else
            {
                Console.WriteLine("Invalid grade.");
            }
        }

        public void PrintInformation()
        {
            Console.WriteLine("Student Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Grade: " + grade);
        }
    }
}