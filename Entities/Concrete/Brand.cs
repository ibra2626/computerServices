using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Brand : IEntity // marka
    {
        public int brand_id { get; set; }
        public string brand_name { get; set; }
    }
}
