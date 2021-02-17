using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class InnerJoinTableInfos
    {
        public string innerTableName { get; set; }
        public string innerTableColumn { get; set; }
        public string baseTableColumn { get; set; }
    }
}
