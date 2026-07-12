using System;

namespace banking_capstone_Solution
{
    internal class Student
    {
        // Fields
        private string name;
        private int age;
        private string address;
        private double grade;

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        // Constructor
        public Student(string name, int age, string address, double grade)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.grade = grade;
        }

        // Print Student Information
        public void PrintInformation()
        {
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Grade: " + grade);
        }

        // Update Address
        public void UpdateAddress(string newAddress)
        {
            address = newAddress;
            Console.WriteLine("Address Updated Successfully.");
        }

        // Update Grade
        public void UpdateGrade(double newGrade)
        {
            if (newGrade >= 0 && newGrade <= 100)
            {
                grade = newGrade;
                Console.WriteLine("Grade Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Grade.");
            }
        }

        // Report Card
        public void ReportCard()
        {
            Console.WriteLine("\n===== Student Report Card =====");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Grade: " + grade);

            if (grade >= 50)
                Console.WriteLine("Result: Pass");
            else
                Console.WriteLine("Result: Fail");
        }

        // Scholarship Eligibility
        public void ScholarshipEligibility()
        {
            Console.WriteLine("\n===== Scholarship Check =====");

            if (grade >= 90)
                Console.WriteLine(name + " is eligible for Scholarship.");
            else
                Console.WriteLine(name + " is NOT eligible for Scholarship.");
        }
    }
}