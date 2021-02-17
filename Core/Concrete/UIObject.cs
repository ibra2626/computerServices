using DataAccess.Concrete;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Concrete
{
    public class Operations<T> where T:IEntity
    {
        /*
         * Burada operation özelliği oluşturuluyor
         * bu özellik hangi database'i kullanacağımızı , hangi sql kodlarını kullanacağımızı belirler
         */
        public dataBaseANDuiBridge<T> operation { get; set; } = new dataBaseANDuiBridge<T>(new SqlDatabaseOperations<T>(new DatabaseConnectionSettings()), new DataToUI<T>()); 
    }
}
