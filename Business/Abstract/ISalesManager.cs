using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISalesManager<T> where T:IEntity
    {
        bool addSales(T entity); // satılan ürünü veritabanına ekler
        
    }
}
