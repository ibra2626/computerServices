using Business.Abstract;
using Core.Concrete;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CashManager<T> : ICashManager<T> where T:IEntity // IcashManager interface'inden implemente edilmiş cashmanger classı IEntity bizim varlıklarımızı (objelerimizi temsil ediyor)
    {
        Operations<T> manager = new Operations<T>(); // Operations classında ki metodlara ulaşmak için bir nesne oluşturuyoruz. 
        public List<T> getAllResolvedFault()
        {
            List<TablesFilterParameters> filters = new List<TablesFilterParameters>(); // 

            TablesFilterParameters filter = new TablesFilterParameters()
            {
                tableName = "faultInfos",
                columnName = "statusID",
                filterValue = "2"
            };
            filters.Add(filter);
            return manager.operation.getAll("faultInfos", null, filters);
           
        }

        public List<T> getAllSoldProducts() // Satılmış olan ürün bilgileri
        {

            List<InnerJoinTableInfos> innerTables = new List<InnerJoinTableInfos>(); // inner join yapılacak tablo listesi

            InnerJoinTableInfos inner = new InnerJoinTableInfos() { 
                baseTableColumn = "productSold_productID",
                innerTableName = "products",
                innerTableColumn = "product_ID"
            };

            List<TablesFilterParameters> filters = new List<TablesFilterParameters>(); // where koşulu uygulanacak tablo,column,value bilgileri

            TablesFilterParameters filter = new TablesFilterParameters()
            {
                tableName = "soldProducts",
                columnName = "productSold_reasonID",
                filterValue = "1"
            };

            innerTables.Add(inner); // listeye oluşturduğumu kuralları ekliyoruz
            filters.Add(filter);// listeye oluşturduğumu kuralları ekliyoruz

            return manager.operation.getAll("soldProducts",innerTables,filters);
        }
    }
}
