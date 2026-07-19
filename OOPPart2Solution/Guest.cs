using System;

namespace OOPPart2Solution
{
    internal class Guest
    {
        public string GuestId;
        public string GuestName;
        public int RoomNumber;
        public string CheckInDate;
        public int TotalNights;

        public Guest(string guestId, string guestName, int roomNumber, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return pricePerNight * TotalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine($"Guest ID     : {GuestId}");
            Console.WriteLine($"Guest Name   : {GuestName}");
            Console.WriteLine($"Room Number  : {RoomNumber}");
            Console.WriteLine($"Check-In     : {CheckInDate}");
            Console.WriteLine($"Total Nights : {TotalNights}");
            Console.WriteLine("----------------------------");
        }
    }
}