using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class SeatBUS
    {
        private SeatDAL dal = new SeatDAL();
        public List<SeatDTO> GetSeatsByShowtime(int roomID, int showtimeID) { return dal.GetSeatsByShowtime(roomID, showtimeID); }
    }
}
