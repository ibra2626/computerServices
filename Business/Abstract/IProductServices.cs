using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServices<T> where T:IEntity
    {
        List<T> getAllMainCategory(); // veritabanından ana kategorileri getirir
        List<T> getAllSubCategory(string mainCategoryID); // veritabanından alt kategorileri getirir
        List<T> getAllProducts(string subCategoryID); // veritabanından tüm ürünleri alt kategoriye göre getirir
        List<T> getAllProductsAndBrand(); // veritabanından ürünleri ve markalarını getirir
        List<T> getAllBrands(); // tüm marka isimlerinin getirir
        bool addBrand(T entity); // yeni bir marka ekle
        bool addProduct(T entity); // yeni bir ürün ekle
        bool updateStock(T entity); // ürünün stoğunu günceller
        bool addMainCategory(T entity); // ana kategori ekler
        bool deleteSubCategoryByID(T entity); // alt kategori siler
        bool deleteProductByID(T entity); // id'ye göre ürün siler
    }
}
