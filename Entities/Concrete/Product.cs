using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity // ürün
    {
        public int product_ID { get; set; }
        public string product_name { get; set; } = null;
        public int? product_subCategoryID { get; set; } = null;
        public int? product_brandID { get; set; } = null;
        public string brand_name { get; set; } = null;
        public int? product_stock { get; set; } = null;
        public decimal? product_purchaseprice { get; set; } = null;
        public decimal? product_saleprice { get; set; } = null;
    }
}
