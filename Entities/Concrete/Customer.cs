using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Entities.Concrete
{
    public class Customer : IEntity // Ientity ile implemente oldu. Ve sadece özelliklerimiz var.
    {
        public int customer_ID { get; set; }
        public string identificationNumber { get; set; }

        public string name { get; set; }

        public string surname{ get; set; }

        public string phoneNumber { get; set; }
    }
}
