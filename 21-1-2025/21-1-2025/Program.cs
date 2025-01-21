using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_2025
{
    internal class Program
    {
        class Room
        {
            private int RoomNumber { set; get; }
            public string RoomType { set; get; }
            public double PricePerNight { set; get; }
            public bool IsBooked { set; get; }
            public const string HotelName = "Grand Stay Hotel";
            public Room()
            {
                RoomNumber = 2;
                RoomType = "single";
                PricePerNight = 150;
                IsBooked = true;
            }
            public Room (int number, string type, double price, bool book)
            {
                RoomNumber = number;
                RoomType = type;
                PricePerNight = price;
                IsBooked = book;
            }
        }
        static void Main(string[] args)
        {
            Room room1 = new Room();
            Room room2 = new Room(5,"single",150,true);
        }
    }
}
