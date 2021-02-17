using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFaultServices<T> where T:IEntity 
    {
        List<T> getAll(); // tüm arızaları ürünleri getir

        List<T> getFaultProduct(); // arızalı ürünün durumunu getirir

        bool add(T entity); // yeni arızalı ürün ekle

        bool updateById(T entity); // arızalı ürün üzerinde yapılan işlemleri update eder
    }
}
