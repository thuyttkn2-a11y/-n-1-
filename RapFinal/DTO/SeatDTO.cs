namespace DTO
{
    public class SeatDTO
    {
        public int    SeatID   { get; set; }
        public int    RoomID   { get; set; }
        public string SeatCode { get; set; }
        public bool   IsBooked { get; set; }
    }
}
