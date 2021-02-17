using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class TablesFilterParameters
    {
        public string tableName { get; set; }
        public string columnName{ get; set; }
        public string filterValue { get; set; }
    }
}
