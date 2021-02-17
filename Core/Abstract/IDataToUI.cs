using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace Core.Abstract
{
    public interface IDatatoUI<T> where T : IEntity
    {
        List<T> convertToEntityList(DataTable dt);
        T dataTableSplitRow(DataRow row);
        
    }
}
