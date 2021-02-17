using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SoldProduct : IEntity // satış yaparken database'e bu bilgiler ile kaydediyoruz
    {
        public int? productSold_ID { get; set; } = null;
        public int productSold_customerID { get; set; }
        public int productSold_productID { get; set; }
        public int productSold_unit { get; set; }
        public int productSold_reasonID { get; set; }
        public string product_name { get; set; } = null;
        public int productSold_totalPrice { get; set; } = 0;
        public DateTime? productSold_soldDate { get; set; } = null;
    }
}
