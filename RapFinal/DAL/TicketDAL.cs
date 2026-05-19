using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class TicketDAL
    {
        public bool BookTicket(int userID, int showtimeID, int seatID)
        {
            string sql = "INSERT INTO Tickets(UserID,ShowtimeID,SeatID,BookingDate) VALUES(@UserID,@ShowtimeID,@SeatID,GETDATE())";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserID",     userID);
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeID);
                    cmd.Parameters.AddWithValue("@SeatID",     seatID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi đặt vé: " + ex.Message); }
        }

        public bool IsSeatBooked(int showtimeID, int seatID)
        {
            string sql = "SELECT COUNT(*) FROM Tickets WHERE ShowtimeID=@ShowtimeID AND SeatID=@SeatID";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ShowtimeID", showtimeID);
                    cmd.Parameters.AddWithValue("@SeatID",     seatID);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi kiểm tra ghế: " + ex.Message); }
        }

        public List<TicketDTO> GetTicketsByUser(int userID)
        {
            var list = new List<TicketDTO>();
            string sql = @"SELECT tk.TicketID,tk.UserID,tk.ShowtimeID,tk.SeatID,tk.BookingDate,
                           m.MovieName,r.RoomName,se.SeatCode,s.ShowDate,s.ShowTime,s.Price
                           FROM Tickets tk
                           INNER JOIN Showtimes s  ON tk.ShowtimeID=s.ShowtimeID
                           INNER JOIN Movies    m  ON s.MovieID=m.MovieID
                           INNER JOIN Rooms     r  ON s.RoomID=r.RoomID
                           INNER JOIN Seats     se ON tk.SeatID=se.SeatID
                           WHERE tk.UserID=@UserID ORDER BY tk.BookingDate DESC";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                        list.Add(new TicketDTO {
                            TicketID    = Convert.ToInt32(r["TicketID"]),
                            UserID      = Convert.ToInt32(r["UserID"]),
                            ShowtimeID  = Convert.ToInt32(r["ShowtimeID"]),
                            SeatID      = Convert.ToInt32(r["SeatID"]),
                            MovieName   = r["MovieName"].ToString(),
                            RoomName    = r["RoomName"].ToString(),
                            SeatCode    = r["SeatCode"].ToString(),
                            ShowDate    = Convert.ToDateTime(r["ShowDate"]),
                            ShowTime    = (TimeSpan)r["ShowTime"],
                            Price       = Convert.ToDecimal(r["Price"]),
                            BookingDate = Convert.ToDateTime(r["BookingDate"])
                        });
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi lấy vé: " + ex.Message); }
            return list;
        }
    }
}
