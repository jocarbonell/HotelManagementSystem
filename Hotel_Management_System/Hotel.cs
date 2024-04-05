using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Hotel
    {
        private List<HotelRoom> _rooms;
        public string Name { get; set; }
        public string Address { get; set; }
        public void DisplayAvailableRooms()
        {
            Console.WriteLine($"\n{Name} - Available Rooms");
            foreach (HotelRoom room in _rooms)
            {
                if (!room.IsOccupied)
                {
                    Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                }
            }
        }
        public void DisplayBookedRooms()
        {
            Console.WriteLine($"\n{Name} - Booked Rooms");
            foreach (HotelRoom room in _rooms)
            {
                if (room.IsOccupied)
                {
                    Console.WriteLine($"Room {room.RoomNumber}, Style: {room.Style}, Price: {room.Price}");
                }
            }
        }