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
    public class FaultManager<T> : IFaultServices<T> where T:IEntity
    {
        Operations<T> faults = new Operations<T>();

        public List<T> getAll()
        {
            
            List<InnerJoinTableInfos> innertables = new List<InnerJoinTableInfos>(); // inner join bilgilerinin ekleneceği liste

            InnerJoinTableInfos table1 = new InnerJoinTableInfos() // inner join tablosu 1
            {
                innerTableName = "faultStatus",
                baseTableColumn = "statusID",
                innerTableColumn = "fault_StatusID"
            };
            InnerJoinTableInfos table2 = new InnerJoinTableInfos()// inner join tablosu 2
            {
                innerTableName = "faultProduct",
                baseTableColumn = "faultProduct_ID",
                innerTableColumn = "faultProduct_ID"
            };
            InnerJoinTableInfos table3 = new InnerJoinTableInfos()// inner join tablosu 3
            {
                innerTableName = "customers",
                baseTableColumn = "customer_ID",
                innerTableColumn = "customer_ID"
            };
            innertables.Add(table1);
            innertables.Add(table2);
            innertables.Add(table3);

            return faults.operation.getAll("faultInfos", innertables); // bilgileri getirir.

        }

        public List<T> getFaultProduct()
        {
            return faults.operation.getAll("faultProduct");
        }
        public bool add(T entity)
        {
            return faults.operation.addData(entity,"faultInfos");
        }
        public List<T> getAllFaultStatus()
        {
            return faults.operation.getAll("faultStatus");
        }
        public bool updateById(T entity)
        {
            return faults.operation.updateDataByID(entity, "faultInfos");
        }
    }
}
