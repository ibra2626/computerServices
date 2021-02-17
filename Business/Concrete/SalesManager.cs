using Business.Abstract;
using Core.Concrete;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SalesManager<T> : ISalesManager<T> where T : IEntity
    {
        Operations<T> manager = new Operations<T>();
        public bool addSales(T entity)
        {
            return manager.operation.addData(entity, "soldProducts");
        }
    }
}
