using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class MovieDAL
    {
        public List<MovieDTO> GetAllMovies()
        {
            var list = new List<MovieDTO>();
            string sql = "SELECT MovieID, MovieName, Genre, Duration, Description FROM Movies";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlDataReader r = new SqlCommand(sql, conn).ExecuteReader();
                    while (r.Read())
                        list.Add(new MovieDTO {
                            MovieID     = Convert.ToInt32(r["MovieID"]),
                            MovieName   = r["MovieName"].ToString(),
                            Genre       = r["Genre"].ToString(),
                            Duration    = Convert.ToInt32(r["Duration"]),
                            Description = r["Description"].ToString()
                        });
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi lấy danh sách phim: " + ex.Message); }
            return list;
        }
    }
}
