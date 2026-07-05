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

























        }
    }
}
