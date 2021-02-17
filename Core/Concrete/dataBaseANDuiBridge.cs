using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Core.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Core.Concrete
{
    public class dataBaseANDuiBridge<T> where T:IEntity
    {

        IDatatoUI<T> _datatoUI;
        IDataBaseOperations<T> _dataBaseOperations;

        public dataBaseANDuiBridge(IDataBaseOperations<T> dataBaseOperations,IDatatoUI<T> datatoUI) // hangi database kodlarının kullanılacağını seçmek için constructor oluşturuyoruz
        {
            _dataBaseOperations = dataBaseOperations;
            _datatoUI = datatoUI;
        }
        public List<T> getAll(string tableName, List<InnerJoinTableInfos> innerTable = null,List<TablesFilterParameters> filters = null) 
        {
            return _datatoUI.convertToEntityList(_dataBaseOperations.getAllData(tableName,innerTable,filters)); // database kodlarından gelen datatable'ı parçalayıp varlıklara eklemek için köprü kuruluyor
        }
        public bool addData(T newDatas,string tableName)
        {
            return _dataBaseOperations.addData(newDatas,tableName); //  ekleme köprü işlemi
        }
        public bool deletedDataByID(T deleteData,string tableName)
        {
           return _dataBaseOperations.deleteDataByID(deleteData, tableName); // silme köprü işlemi
        }
        public bool updateDataByID(T updateData,string tableName) // güncelleme köprü işlemi
        {
            return _dataBaseOperations.updataDataByID(updateData, tableName);
        }
    }
}
