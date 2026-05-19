using System;
namespace DTO
{
    public class ShowtimeDTO
    {
        public int      ShowtimeID { get; set; }
        public int      MovieID    { get; set; }
        public int      RoomID     { get; set; }
        public string   MovieName  { get; set; }
        public string   RoomName   { get; set; }
        public DateTime ShowDate   { get; set; }
        public TimeSpan ShowTime   { get; set; }
        public decimal  Price      { get; set; }
    }
}
