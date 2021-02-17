using System.Data.SqlClient;

namespace DataAccess.Concrete
{
    public interface IDatabaseConnection
    {
        SqlConnection sqlConnection();  // Sql bağlantı fonksiyonu

    }
}
