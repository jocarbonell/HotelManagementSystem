using Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Booking
    {
        private static int _reservationNumberSeed = 1234567890;
        public int ReservationNumber { get; private set; }
        public Hotel Hotel { get; set; }
        public HotelRoom Room { get; set; }
        public int Price { get; set; }
        public User User { get; set; }

        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Duration { get; set; }
        public Booking(DateTime checkin, DateTime checkout, HotelRoom room)
        {
            room.IsOccupied = true;
            Room = room;
            Price = room.Price;
            CheckIn = checkin;
            CheckOut = checkout;
            Duration = checkout.Subtract(checkin).Days;
            ReservationNumber = _reservationNumberSeed++;
        }
    }
}