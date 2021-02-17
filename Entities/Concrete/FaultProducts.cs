using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FaultProducts :IEntity // arızalı ürün durumu (çözüldü,beklemede vs.)
    {
        public int faultProduct_ID { get; set; }
        public string faultProduct_reason { get; set; }
    }
}
