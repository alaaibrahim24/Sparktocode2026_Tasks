using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPPart2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            // Preloaded Rooms
            rooms.Add(new Room(101, "Single", 25, true));
            rooms.Add(new Room(102, "Single", 30, true));
            rooms.Add(new Room(201, "Double", 45, true));
            rooms.Add(new Room(202, "Double", 50, true));
            rooms.Add(new Room(301, "Suite", 80, true));
            rooms.Add(new Room(302, "Suite", 100, true));

            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("=================================");
                Console.WriteLine(" GRAND VISTA HOTEL MANAGEMENT ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add New Room");
                Console.WriteLine("2. Register New Guest");
                Console.WriteLine("3. Book a Room");
                Console.WriteLine("4. View All Rooms");
                Console.WriteLine("5. View All Guests");
                Console.WriteLine("6. Search & Filter Rooms");
                Console.WriteLine("7. Guest & Booking Statistics");
                Console.WriteLine("8. Update Room Price");
                Console.WriteLine("9. Guest Lookup by Name");
                Console.WriteLine("10. Room Type Breakdown Report");
                Console.WriteLine("11. Check Out a Guest");
                Console.WriteLine("12. Remove Unavailable Rooms");
                Console.WriteLine("13. Extend Guest Stay");
                Console.WriteLine("14. Highest Revenue Booking");
                Console.WriteLine("15. Guest Pagination Viewer");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;

                    case 2:
                        Console.WriteLine("Case 2");
                        break;

                    case 3:
                        Console.WriteLine("Case 3");
                        break;

                    case 4:
                        Console.WriteLine("Case 4");
                        break;

                    case 5:
                        Console.WriteLine("Case 5");
                        break;

                    case 6:
                        Console.WriteLine("Case 6");
                        break;

                    case 7:
                        Console.WriteLine("Case 7");
                        break;

                    case 8:
                        Console.WriteLine("Case 8");
                        break;

                    case 9:
                        Console.WriteLine("Case 9");
                        break;

                    case 10:
                        Console.WriteLine("Case 10");
                        break;

                    case 11:
                        Console.WriteLine("Case 11");
                        break;

                    case 12:
                        Console.WriteLine("Case 12");
                        break;

                    case 13:
                        Console.WriteLine("Case 13");
                        break;

                    case 14:
                        Console.WriteLine("Case 14");
                        break;

                    case 15:
                        Console.WriteLine("Case 15");
                        break;

                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}