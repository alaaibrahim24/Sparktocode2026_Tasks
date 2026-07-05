namespace Task1Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Task 1: Personal Info Card

            string name = "Sara";
            int age = 21;
            double height = 1.65;
            bool isStudent = true;
            Console.WriteLine($"Name: {name}\nAge: {age}\nHeight: {height}\nStudent: {isStudent}");


            ///////////////////////////////////////////////////////////
            ///



            //Task 2: Rectangle Calculator

            Console.Write("Enter length: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            double wid = double.Parse(Console.ReadLine());
            Console.WriteLine($"Area: {len * wid}, Perimeter: {2 * (len + wid)}");

            //////////////////////////////////////////////////////////
            ///


            //Task 3: Even or Odd Checker


            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) Console.WriteLine("Even");
            else Console.WriteLine("Odd");

            /////////////////////////////////////////////////////////
            ///






















        }
    }
}
