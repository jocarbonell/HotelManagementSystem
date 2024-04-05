namespace Hotel_Management_System
{
        internal class Program
    {
        static void Main(string[] args)
        {
            List<HotelRoom> sunwooRooms = new List<HotelRoom>();
            HotelRoom room1 = new HotelRoom(101, RoomStyle.Twin, 182);
            HotelRoom room2 = new HotelRoom(102, RoomStyle.King, 376);
            sunwooRooms.Add(room1);
            sunwooRooms.Add(room2);
            Hotel hotelSunwoo = new Hotel("Hotel Sunwoo", "0412 KimStre, TheBoyz City", sunwooRooms);

            List<HotelRoom> hotelBambamRooms = new List<HotelRoom>();
            HotelRoom hotelBambamRoom1 = new HotelRoom(201, RoomStyle.Queen, 2000);
            HotelRoom hotelBambamRoom2 = new HotelRoom(202, RoomStyle.Queen, 2000);
            hotelBambamRooms.Add(hotelBambamRoom1);
            hotelBambamRooms.Add(hotelBambamRoom2);
            Hotel hotelBambam = new Hotel("Hotel Bambam", "Seoul, South Korea", hotelBambamRooms);

            HotelManagementSystem hms = new HotelManagementSystem();
            hms.AddHotel(hotelSunwoo);
            hms.AddHotel(hotelBambam);

            hms.DisplayHotels();

            hotelSunwoo.DisplayAvailableRooms();

            Guest owyn = new Guest("Owyn", "Addr 4", "owyn@email.com", 63911728, "sunwoobambam");
            hms.RegisterUser(owyn);

            hms.CreateBooking(hotelSunwoo, room2, owyn, DateTime.Now, new DateTime(2024, 07, 27));
            hotelSunwoo.DisplayBookedRooms();
            owyn.DisplayBookings();

            Receptionist jackson = new Receptionist("Jackson", "Addr 5", "jackson@gmail.com", 0330, "wangwabg");
            hms.RegisterUser(jackson);

            Booking res = new Booking(new DateTime(2024, 07, 01), new DateTime(2024, 09, 27), hotelBambamRoom2);
            anna.BookReservation(owyn, jackson);

            owyn.DisplayBookings();
            hms.DisplayBookingDetails(182829);
            Console.WriteLine(owyn.TotalRoomCount);
        }
    }
}