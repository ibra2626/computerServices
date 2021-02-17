using Core.Abstract;
using DevExpress.XtraEditors;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Core.Concrete
{
    public class DataToUI<T> : IDatatoUI<T> where T : IEntity
    {
        public List<T> convertToEntityList(DataTable dt) // databaseden bilgileri alıyor.
        {
            List<T> entityList = new List<T>(); // Varlık listesi oluşturuyoruz

            foreach (DataRow row in dt.Rows) // datatable içerisinde bulunan satırları tek tek geziyoruz
            {
                T item = dataTableSplitRow(row); // dattable'dan alınan satır dataTableSplitRow() foksiyonuna parçalanması için gönderiliyor
                entityList.Add(item); // IEntity varlığı içerisine yerleştirilen bilgiler bir nesne olrak lsiteye ekleniyor.
            }
            return entityList; // liste formda kullanılmak üzere gönderiliyor.
        }
        public T dataTableSplitRow(DataRow row) // satır bilgisi alınıyor
        {
            Type temp = typeof(T); // T nesnesi bir IEntity implementi olmak zorunda bundan dolayı tipini öğreniyoruz. "Customer","Product" vs

            T entity = Activator.CreateInstance<T>(); // IEntity tipinde bir örnek entity nesnesine tanımlanıyor

            foreach (DataColumn column in row.Table.Columns) // row içerisinde ki columnlar geziliyor
            {
                foreach (PropertyInfo pro in temp.GetProperties()) // // temp içerisinde ki özellikler alınıyor
                {

                    if (pro.Name == column.ColumnName) {  // eğer özellik ismi sütun ismine eşitse satırdaki bilgi entity nesnesine ekleniyor.
                        if (row[column.ColumnName] != DBNull.Value)
                        {
                            pro.SetValue(entity, row[column.ColumnName], null); // burada entity nesnesine databaseden gelen değer ekleniyor.
                        }
                    }
                    else
                        continue;
                }
            }
            return entity;
        }

    }
}
