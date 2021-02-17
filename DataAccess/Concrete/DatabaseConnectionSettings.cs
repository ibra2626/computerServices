using System.Data.SqlClient;

namespace DataAccess.Concrete
{
    public class DatabaseConnectionSettings : IDatabaseConnection // İmplement işlemi
    {

        public SqlConnection sqlConnection()
        {
            // sql bağlantısı yapılıyor.
            SqlConnection connection = new SqlConnection("Data Source=IMPULSE\\SQLEXPRESS;Initial Catalog=teknik_servis;Integrated Security=True");
            return connection; // yapılan sql bağlantısı dışa gönderiliyor.
        }
    }
}
