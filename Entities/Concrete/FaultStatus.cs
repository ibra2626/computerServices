using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FaultStatus : IEntity
    {
        public int fault_statusID { get; set; }
        public string fault_status { get; set; }
    }
}
