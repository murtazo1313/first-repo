using System;

namespace Booking
{
    public class Room
    {
        public int ID;
        public string Type;
        public int Floor;
        public decimal Price;
        public int Capacity;
        public RoomStatus Status;
        public string Description;      

        public enum RoomStatus
        {
            Available,
            Occupied,
            Reserved
        }
    }
}
