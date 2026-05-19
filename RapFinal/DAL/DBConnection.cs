using System.Data.SqlClient;

namespace DAL
{
    public class DBConnection
    {
        private static string connectionString =
            "Data Source=LAPTOP-RLFJ1HSE;Initial Catalog=QuanLyRapChieuPhim;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
