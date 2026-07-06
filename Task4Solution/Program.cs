namespace Task4Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Task 1 (PrintWelcome)

            static void PrintWelcome(string name) { Console.WriteLine("Welcome, " + name + "!"); }

            ///////////////////////////////////////////////////
            ///

            //Task 2 (Square)

            static int Square(int n) { return n * n; }

            /////////////////////////////////////////////////////
            ///

            //Task 3 (CelsiusToFahrenheit)

            static double CelsiusToFahrenheit(double c) { return (c * 9 / 5) + 32; }

            //////////////////////////////////////////////////////
            ///

            //Task 4 (DisplayMenu)

            static void DisplayMenu() { Console.WriteLine("1) Start\n2) Help\n3) Exit"); }

            //////////////////////////////////////////////////////
            ///


            //Task 5 (IsEven)

            static bool IsEven(int n) { return n % 2 == 0; }

            //////////////////////////////////////////////////////
            ///

            //Task 6 (Area & Perimeter)

            static double CalculateArea(double l, double w) { return l * w; }
            static double CalculatePerimeter(double l, double w) { return 2 * (l + w); }

            //////////////////////////////////////////////////////
            ///

            //Task 7 (GetGradeLetter)

            static string GetGradeLetter(int score)
            {
                if (score >= 90) return "A";
                else if (score >= 80) return "B";
                else if (score >= 70) return "C";
                else if (score >= 60) return "D";
                else return "F";
            }
            ///////////////////////////////////////////////////////
            ///

            //Task 8 (Countdown)

            static void Countdown(int n) { for (int i = n; i >= 1; i--) Console.WriteLine(i); }

            //////////////////////////////////////////////////////
            ///



































        }
    }
}
