using Business.Abstract;
using Core.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerServices<Customer>
    {
        Operations<Customer> customers = new Operations<Customer>(); // Customer nesnesiyle işlem yapılacak operasyonlar
        public List<Customer> getAll() // müşterileri getir
        {

            return customers.operation.getAll("customers");
        }
        public bool add(Customer entity) // müşteir ekle
        {
            return customers.operation.addData(entity,"customers");
        }

        public bool deleteDataByID(Customer entity) // müşteri sil
        {
            return customers.operation.deletedDataByID(entity,"customers");
        }

        public bool updateDataByID(Customer entity) // müşteri güncelle
        {
            return customers.operation.updateDataByID(entity, "customers");
        }
    }
}
