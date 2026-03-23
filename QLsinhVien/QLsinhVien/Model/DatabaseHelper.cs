using System.Data.SqlClient;
using System.Configuration;

namespace QLsinhVien.Models
{
    public class DatabaseHelper
    {
        // Lấy connection string từ App.config
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["QLSVConnectionString"].ConnectionString;
        }

        // Mở kết nối
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(GetConnectionString());
        }
    }
}