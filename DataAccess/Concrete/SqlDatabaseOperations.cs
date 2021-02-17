using DataAccess.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace DataAccess.Concrete
{
    public class SqlDatabaseOperations<T> : IDataBaseOperations<T> where T : IEntity// implement yapılıyor
    {
        IDatabaseConnection _DatabaseConnection;
        public SqlDatabaseOperations(IDatabaseConnection DatabaseConnection)// constructor oluşturuluyor. -- Bir database bağlantı arayüzü(referans) isteniyor
        {

            _DatabaseConnection = DatabaseConnection;
        }

        /*
         *Bu fonksiyon isteğe bağlı innerJoinTableInfos ve filter List'lerini desteklemektedir.
         * 
         * Eğer bir tabloyu inner join sorgusu ile birleştireceksek bu fonksiyona List<InnerJoinTableInfos> tipinde bir liste gönderilmeli
         * Bu liste inner join yapılacak tablo bilgilerini içermektedir.
         * innerJoinTableInfos adında ki class ta hangi bilgilerin istendiği yazmaktadır.
         * 
         * 
         * Eğer tabloya filtre uygulama yani WHERE koşulu ile sorgulamak istersek List<TablesFilterParameters> tipinde bir liste göndermeliyiz
         * Bu listede where komutu uygulayacağımız tablo,sütun adı , ve istenilen değer bulunmaktadır.
         * TablesFilterParameters adlı class'ta özellikler belirtilmektedir.
         * 
         **/
        public DataTable getAllData(string tableName, List<InnerJoinTableInfos> innerJoinTableInfos = null, List<TablesFilterParameters> filter = null) 
        {
            string cmdString = $"SELECT * FROM {tableName}"; // Database 'E gönderilecek sorgu başlangıcı

            if (innerJoinTableInfos != null)  // innerJoinTableInfos değeri varsa
            {
                for (int i = 0; i < innerJoinTableInfos.Count; i++) // innerJoinTableInfos listesindeki objeleri say ve tek tek sorguya ekle
                {
                    cmdString += $" INNER JOIN {innerJoinTableInfos[i].innerTableName} ON {tableName}.{innerJoinTableInfos[i].baseTableColumn}={innerJoinTableInfos[i].innerTableName}.{innerJoinTableInfos[i].innerTableColumn}"; // sql'E gönderilecek sorguya innerJoinTableInfos içerisindeki bilgiler ekleniyor.
                }
            }
            if (filter != null) // filter listesi boş değilse
            {
                if (filter.Count > 1) // eğer filterda 1 dern fazla koşul varsa  48. satırda ki kodu 1 kere çalıştır
                {
                    cmdString += $" WHERE {filter[0].tableName}.{filter[0].columnName} = {filter[0].filterValue}"; // bura 1 kere çalışır

                    for (int i = 1; i < filter.Count; i++) // filter listesinin uzunluğu alınıyor
                    {
                        cmdString += $" AND {filter[i].tableName}.{filter[i].columnName} = {filter[i].filterValue}"; // filter listesindeki where koşulları tek tek yazılıyor
                    }
                }
                else // eğer filter'da 1 tane koşul varsa bu blok çalışacak
                {
                    cmdString += $" WHERE {filter[0].tableName}.{filter[0].columnName} = {filter[0].filterValue}"; // 1 tane where koşulu ekler
                }
            }

            DataTable dt = new DataTable();

            using (SqlConnection connection = _DatabaseConnection.sqlConnection()) // Burada "con" nesnesine sql bağlantı ayarlarımızı gönderdik (şifre,kullanıcıadi,servername vb.) -- Bu bilgileri DatabaseConnectionSetting class'ından aldık.
            {
                using (SqlCommand cmd = new SqlCommand(cmdString, connection)) // sql'e gönderilecek sorguyu oluşturduk ve bağlantı bilgileriyle birlikte "cmd" nesnesine ekledik.
                {
                    connection.Open(); // yukarıda oluşturulan bilgilerle bağlantıyı açtık
                    using (SqlDataReader reader = cmd.ExecuteReader()) // "cmd" nesnesinde bulunan bilgilerle verileri okuduk ve "reader" nesnesine hepsini ekledik.
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }

        public bool addData(T entity, string tableName)
        {
            string tableFieldNames = $"INSERT INTO {tableName} ("; // tablo ismi ekleniyor
            string datas = " VALUES("; // gönderilecek değerlerin başlangıcı


            Type objectType = entity.GetType(); // burada gönderilen entity objesi bir varlık.Bu varlığın tipi alınıyor.

            PropertyInfo[] propInfos = objectType.GetProperties(); // alınan tipe göre varlığın yani nesnenin içerisinde ki  özellikler alınıyor. ÖRN: customerID,customername gibi

            for (int i = 1; i < propInfos.Length; i++) // objedeb alınan değerler tek tek sorgu cümlesine ekleniyor
            {
                if (i != propInfos.Length-1) 
                {
                    if (objectType.GetProperty(propInfos[i].Name).GetValue(entity) != null)
                    {
                        tableFieldNames += $"{propInfos[i].Name},"; // burada obje içerisindeki property'nin ismi alınıyor ÇRN : customer_id,product_ID vb.
                        datas += $"'{objectType.GetProperty(propInfos[i].Name).GetValue(entity)}',"; // Burada ise özelliğin içerisinde ki değer alınıyor. "ali","ayşe" vb.
                    }

                }
                else
                {
                    if (objectType.GetProperty(propInfos[i].Name).GetValue(entity) != null)
                    {
                        tableFieldNames += $"{propInfos[i].Name})";
                        datas += $"'{objectType.GetProperty(propInfos[i].Name).GetValue(entity)}')";
                    }
                }
            }


            string cmdString = tableFieldNames + datas;
            try
            {
                using (SqlConnection connection = _DatabaseConnection.sqlConnection()) // Burada "con" nesnesine sql bağlantı ayarlarımızı gönderdik (şifre,kullanıcıadi,servername vb.) -- Bu bilgileri DatabaseConnectionSetting class'ından aldık.
                {
                    using (SqlCommand cmd = new SqlCommand(cmdString, connection)) // sql'e gönderilecek sorguyu oluşturduk ve bağlantı bilgileriyle birlikte "cmd" nesnesine ekledik.
                    {
                        connection.Open(); // yukarıda oluşturulan bilgilerle bağlantıyı açtık
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
        public bool deleteDataByID(T entity, string tableName)
        {
            Type objectType = entity.GetType();// burada gönderilen entity objesi bir varlık.Bu varlığın tipi alınıyor.

            PropertyInfo[] propInfos = objectType.GetProperties(); // alınan tipe göre varlığın yani nesnenin içerisinde ki  özellikler alınıyor. ÖRN: customerID,customername gibi

            string cmdString = $"DELETE FROM {tableName} WHERE {propInfos[0].Name}={objectType.GetProperty(propInfos[0].Name).GetValue(entity)}"; // gönderilecek sorgu oluşturuluyor.
            try
            {
                using (SqlConnection connection = _DatabaseConnection.sqlConnection()) // Burada "con" nesnesine sql bağlantı ayarlarımızı gönderdik (şifre,kullanıcıadi,servername vb.) -- Bu bilgileri DatabaseConnectionSetting class'ından aldık.
                {
                    using (SqlCommand cmd = new SqlCommand(cmdString, connection)) // sql'e gönderilecek sorguyu oluşturduk ve bağlantı bilgileriyle birlikte "cmd" nesnesine ekledik.
                    {
                        connection.Open(); // yukarıda oluşturulan bilgilerle bağlantıyı açtık
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // işlem olumlu
            }
            catch (Exception)
            {

                return false; // işlem olumsuz
            }

        }

        public bool updataDataByID(T entity, string tableName)
        {
            Type objectType = entity.GetType();

            PropertyInfo[] propInfos = objectType.GetProperties();

            string cmdString = $"UPDATE {tableName} SET ";
            for (int i = 1; i < propInfos.Length; i++)
            {
                if (i < propInfos.Length - 1)
                {
                    if (objectType.GetProperty(propInfos[i].Name).GetValue(entity) != null)
                    {
                        cmdString += $"{propInfos[i].Name} = '{objectType.GetProperty(propInfos[i].Name).GetValue(entity)}',";
                    }

                }
                else
                {
                    if (objectType.GetProperty(propInfos[i].Name).GetValue(entity) != null)
                    {
                        cmdString += $"{propInfos[i].Name} = '{objectType.GetProperty(propInfos[i].Name).GetValue(entity)}'";
                    }
                }
            }

            cmdString += $" WHERE {propInfos[0].Name}= {objectType.GetProperty(propInfos[0].Name).GetValue(entity)}";
            try
            {
                using (SqlConnection connection = _DatabaseConnection.sqlConnection()) // Burada "con" nesnesine sql bağlantı ayarlarımızı gönderdik (şifre,kullanıcıadi,servername vb.) -- Bu bilgileri DatabaseConnectionSetting class'ından aldık.
                {
                    using (SqlCommand cmd = new SqlCommand(cmdString, connection)) // sql'e gönderilecek sorguyu oluşturduk ve bağlantı bilgileriyle birlikte "cmd" nesnesine ekledik.
                    {
                        connection.Open(); // yukarıda oluşturulan bilgilerle bağlantıyı açtık
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}