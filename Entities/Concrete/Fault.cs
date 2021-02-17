using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace Entities.Concrete
{
    public class Fault : IEntity // arızalı ürün bilgileri
    {
        public int id { get; set; }
        public int? customer_ID { get; set; } = null;
        public string identificationNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int? faultProduct_ID { get; set; } = null;
        public string solutionDetail { get; set; }
        public string faultProduct_reason{ get; set; }
        public decimal price { get; set; }
        public string phoneNumber { get; set; }
        public string model { get; set; }
        public string component { get; set; }
        public string detail{ get; set; }
        public DateTime? startDate { get; set; } = null;
        public DateTime? finishDate { get; set; } = null;
        public string fault_status { get; set; }
        public int statusID { get; set; }


    }
}
