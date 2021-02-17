using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICashManager<T> where T:IEntity // Kasa işlemleri için interface
    {
        List<T> getAllResolvedFault(); // arızası giderilmiş ürünleri çek

        List<T> getAllSoldProducts(); // satışı yapılmış ürünleri çek
    }
}
