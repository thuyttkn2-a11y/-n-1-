using System;
namespace DTO
{
    public class TicketDTO
    {
        public int      TicketID    { get; set; }
        public int      UserID      { get; set; }
        public int      ShowtimeID  { get; set; }
        public int      SeatID      { get; set; }
        public string   MovieName   { get; set; }
        public string   RoomName    { get; set; }
        public string   SeatCode    { get; set; }
        public DateTime ShowDate    { get; set; }
        public TimeSpan ShowTime    { get; set; }
        public decimal  Price       { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
