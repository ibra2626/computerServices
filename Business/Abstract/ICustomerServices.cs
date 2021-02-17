using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerServices<T> where T : IEntity
    {
        List<T> getAll(); // tüm müşterileri çek

        bool add(T entity); // müşteri ekle
        bool deleteDataByID(T entity); // id'ye göre müşteriyi sil
        bool updateDataByID(T entity); // id'ye göre müşteri bilgisini güncelle
    }
}
