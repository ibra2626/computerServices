using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class MainCategory : IEntity // ana kategori
    {
        public int mainCategory_ID { get; set; }
        public string mainCategory_name { get; set; }
    }
}
