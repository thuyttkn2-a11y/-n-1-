using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class TicketBUS
    {
        private TicketDAL dal = new TicketDAL();
        public bool BookTicket(int userID, int showtimeID, int seatID)
        {
            if (dal.IsSeatBooked(showtimeID, seatID))
                throw new Exception("Ghế này đã được đặt. Vui lòng chọn ghế khác.");
            return dal.BookTicket(userID, showtimeID, seatID);
        }
        public List<TicketDTO> GetTicketsByUser(int userID) { return dal.GetTicketsByUser(userID); }
    }
}
