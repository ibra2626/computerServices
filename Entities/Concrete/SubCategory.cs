using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SubCategory : IEntity // alt kategori
    {
        public int subCategory_ID { get; set; }
        public int subCategory_mainCatgID { get; set; }
        public string subCategory_name { get; set; }
    }
}
