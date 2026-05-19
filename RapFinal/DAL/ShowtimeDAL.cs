using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class ShowtimeDAL
    {
        public List<ShowtimeDTO> GetShowtimesByMovie(int movieID)
        {
            var list = new List<ShowtimeDTO>();
            string sql = @"SELECT s.ShowtimeID,s.MovieID,s.RoomID,m.MovieName,r.RoomName,
                           s.ShowDate,s.ShowTime,s.Price
                           FROM Showtimes s
                           INNER JOIN Movies m ON s.MovieID=m.MovieID
                           INNER JOIN Rooms  r ON s.RoomID=r.RoomID
                           WHERE s.MovieID=@MovieID ORDER BY s.ShowDate,s.ShowTime";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MovieID", movieID);
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                        list.Add(new ShowtimeDTO {
                            ShowtimeID = Convert.ToInt32(r["ShowtimeID"]),
                            MovieID    = Convert.ToInt32(r["MovieID"]),
                            RoomID     = Convert.ToInt32(r["RoomID"]),
                            MovieName  = r["MovieName"].ToString(),
                            RoomName   = r["RoomName"].ToString(),
                            ShowDate   = Convert.ToDateTime(r["ShowDate"]),
                            ShowTime   = (TimeSpan)r["ShowTime"],
                            Price      = Convert.ToDecimal(r["Price"])
                        });
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi lấy suất chiếu: " + ex.Message); }
            return list;
        }
    }
}
