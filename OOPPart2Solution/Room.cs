using System;

namespace OOPPart2Solution
{
    internal class Room
    {
        public int RoomNumber;
        public string RoomType;
        public double PricePerNight;
        public bool IsAvailable;

        public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }

        public void DisplayRoom()
        {
            Console.WriteLine($"Room Number : {RoomNumber}");
            Console.WriteLine($"Room Type   : {RoomType}");
            Console.WriteLine($"Price       : {PricePerNight}");
            Console.WriteLine($"Available   : {IsAvailable}");
            Console.WriteLine("----------------------------");
        }
    }
}