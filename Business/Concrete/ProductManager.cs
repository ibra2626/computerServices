using Business.Abstract;
using Core.Concrete;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager<T> : IProductServices<T> where T:IEntity
    {
        Operations<T> entities = new Operations<T>();

        public List<T> getAllProductsAndBrand() // ürün ve markalrı getir
        {
            List<InnerJoinTableInfos> innertables = new List<InnerJoinTableInfos>();

            InnerJoinTableInfos table1 = new InnerJoinTableInfos()
            {
                innerTableName = "brands",
                baseTableColumn = "product_brandID",
                innerTableColumn = "brand_id"
            };
            innertables.Add(table1);

            return entities.operation.getAll("products",innertables);
        }
        public List<T> getAllProducts(string subCategoryID) // tüm ürünleri getir
        {
            
            
            List<TablesFilterParameters> filters = new List<TablesFilterParameters>();

            List<InnerJoinTableInfos> innertables = new List<InnerJoinTableInfos>();

            InnerJoinTableInfos table1 = new InnerJoinTableInfos()
            {
                innerTableName = "brands",
                baseTableColumn = "product_brandID",
                innerTableColumn = "brand_id"
            };
            innertables.Add(table1);

            TablesFilterParameters filter1 = new TablesFilterParameters()
            {
                tableName = "products",
                columnName = "product_subCategoryID",
                filterValue = subCategoryID
            };

            filters.Add(filter1);
            return entities.operation.getAll("products", innertables, filters);
        }
        public List<T> getAllMainCategory() // ana kategorileri getir
        {
         

            return entities.operation.getAll("mainCategory");
        }
        public List<T> getAllBrands() // tüm markaları getir
        {
            return entities.operation.getAll("brands");
        }
        public List<T> getAllSubCategory(string mainCategoryID) // alt kategorileri getir
        {

            List<TablesFilterParameters> filters = new List<TablesFilterParameters>();

            TablesFilterParameters filter1 = new TablesFilterParameters() {
                tableName = "subCategory",
                columnName = "subCategory_mainCatgID",
                filterValue = mainCategoryID
            };
            filters.Add(filter1);

            return entities.operation.getAll("subCategory",null,filters);
        }

        public bool addBrand(T entity) // marka ekle
        {
            return entities.operation.addData(entity,"brands");
        }

        public bool addProduct(T entity) // ürün ekle
        {
            return entities.operation.addData(entity, "products");
        }
        public bool addMainCategory(T entity) // ana kategori ekle
        {
            return entities.operation.addData(entity, "mainCategory");
        }
        public bool addSubCategory(T entity) // alt kategori ekle
        {
            return entities.operation.addData(entity, "subCategory");
        }
        public bool updateStock(T entity) // stock güncelle
        {
            return entities.operation.updateDataByID(entity, "products");
        }
        public bool deleteSubCategoryByID(T entity) // alt kategori sil
        {
            return entities.operation.deletedDataByID(entity, "subCategory");

        }
        public bool deleteProductByID(T entity) // ürün sil
        {
            return entities.operation.deletedDataByID(entity, "products");

        }

    }
}
