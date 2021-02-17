using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Abstract
{
    public interface IDataBaseOperations<T> where T:IEntity // T IEntity'den implemente edilmiş bir nesne olmak zorunda
    {
        DataTable getAllData(string tableName, List<InnerJoinTableInfos> innerJoinTableInfos=null, List<TablesFilterParameters> filter = null); // içine gönderilen değerler ile veri çekmek için kullanıulan fonksiyon
        bool addData(T entity, string tableName); //  kendisine gönderilen değerleri database'e kaydeder
        bool deleteDataByID(T entity, string tableName); // id'ye göre silme işlemi yapar

        bool updataDataByID(T entity, string tableName); // id'ye göre update işlemi yapar.
    }
}
