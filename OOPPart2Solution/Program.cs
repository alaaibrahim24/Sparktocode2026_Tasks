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
                    
                        
                        Console.Write("Enter Room Number: ");

                        if (!int.TryParse(Console.ReadLine(), out int num) || num <= 0)
                        {
                            Console.WriteLine("Error: Room number must be a positive integer.");
                            break;
                        }

                        if (rooms.Any(r => r.RoomNumber == num))
                        {
                            Console.WriteLine("Error: Room number already exists.");
                            break;
                        }

                        Console.Write("Enter Room Type (Single/Double/Suite): ");
                        string type = Console.ReadLine();

                        Console.Write("Enter Price Per Night: ");

                        if (!double.TryParse(Console.ReadLine(), out double price) || price <= 0)
                        {
                            Console.WriteLine("Error: Price must be a positive decimal.");
                            break;
                        }

                        rooms.Add(new Room(num, type, price, true));

                        Console.WriteLine($"Room {num} added successfully!");
                        Console.WriteLine($"Total rooms: {rooms.Count}");

                        break;


                    case 2:
                        Console.Write("Enter Guest ID: ");
                        string id = Console.ReadLine();

                        if (guests.Any(g => g.GuestId == id))
                        {
                            Console.WriteLine("Error: Guest ID already exists.");
                            break;
                        }

                        Console.Write("Enter Guest Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Check-in Date (YYYY-MM-DD): ");
                        string checkInDate = Console.ReadLine();

                        Console.Write("Enter Total Nights: ");

                        if (!int.TryParse(Console.ReadLine(), out int nights) || nights <= 0)
                        {
                            Console.WriteLine("Error: Total nights must be a positive integer.");
                            break;
                        }

                        guests.Add(new Guest(id, name, 0, checkInDate, nights));

                        Console.WriteLine($"Guest {name} registered successfully!");
                        Console.WriteLine($"Total guests: {guests.Count}");

                        break;




                    case 3:
                        BookRoom(rooms, guests);
                        break;

                    case 4:
                        Console.WriteLine("Case 4");
                        if (!rooms.Any())
                        {
                            Console.WriteLine("No rooms have been added yet.");
                        }
                        else
                        {
                            Console.WriteLine($"Total Rooms: {rooms.Count}\n");
                            var sortedRooms = rooms.OrderBy(r => r.RoomNumber).ToList();
                            foreach (var r in sortedRooms)
                            {
                                r.DisplayRoom();
                            }
                        }
                        
                        break;

                    case 5:
                        Console.WriteLine("Case 5");
                        if (!guests.Any())
                        {
                            Console.WriteLine("No guests have been registered yet.");
                        }
                        else
                        {
                            Console.WriteLine($"Total Guests: {guests.Count}\n");
                            var sortedGuests = guests.OrderBy(g => g.GuestName).ToList();
                            foreach (var g in sortedGuests)
                            {
                                g.DisplayGuest();
                            }
                        }
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

                    case 0:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;

                }

                if (!exit)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private static void BookRoom(List<Room> rooms, List<Guest> guests)
        {
            throw new NotImplementedException();
        }
    }
}