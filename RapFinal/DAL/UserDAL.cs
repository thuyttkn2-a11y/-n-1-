using System;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class UserDAL
    {
        public UserDTO Login(string username, string password)
        {
            UserDTO user = null;
            string sql = "SELECT UserID, Username, Password, FullName " +
                         "FROM Users WHERE Username=@Username AND Password=@Password";
            try
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    SqlDataReader r = cmd.ExecuteReader();
                    if (r.Read())
                        user = new UserDTO {
                            UserID   = Convert.ToInt32(r["UserID"]),
                            Username = r["Username"].ToString(),
                            Password = r["Password"].ToString(),
                            FullName = r["FullName"].ToString()
                        };
                }
            }
            catch (Exception ex) { throw new Exception("Lỗi đăng nhập: " + ex.Message); }
            return user;
        }
    }
}
