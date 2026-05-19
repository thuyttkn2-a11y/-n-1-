using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class SeatDAL
    {
        public List<SeatDTO> GetSeatsByShowtime(int roomID, int showtimeID)
        {
            var list = new List<SeatDTO>();
            string sql = @"SELECT se.SeatID,se.RoomID,se.SeatCode,
                           CASE WHEN t.TicketID IS NOT NULL THEN 1 ELSE 0 END AS IsBooked
                           FROM Seats se
                           LEFT JOIN Tickets t ON se.SeatID=t.SeatID AND t.ShowtimeID=@ShowtimeID
                           WHERE se.RoomID=@RoomID ORDER BY se.SeatCode";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@RoomID",     roomID);
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeID);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                        list.Add(new SeatDTO {
                            SeatID   = Convert.ToInt32(r["SeatID"]),
                            RoomID   = Convert.ToInt32(r["RoomID"]),
                            SeatCode = r["SeatCode"].ToString(),
                            IsBooked = Convert.ToInt32(r["IsBooked"]) == 1
                        });
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi lấy ghế: " + ex.Message); }
            return list;
        }
    }
}
