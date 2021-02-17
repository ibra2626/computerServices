using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FaultAdded :IEntity // arızalı ürünü database'e eklerken kullancağımız obje
    {
        public int id { get; set; }
        public int customer_ID { get; set; }
        public int faultProduct_ID { get; set; }
        public string model { get; set; }
        public string component { get; set; }
        public string detail { get; set; }
        public decimal price { get; set; }
        public DateTime startDate { get; set; }
        public Int16 statusID { get; set; }


    }
}
