using System.Collections.Generic;

namespace DataAccessLayer.Interfaces
{
    public interface IRepository<T> 
        where T : class
    {
        IEnumerable<T> GetAll();  // отримання всіх об'єктів
        T GetById(int Id);        // отримання одного об'єкта по ID
        void Create(T item);      // створення об'єкта
        void Update(T item);      // оновлення об'єкта
        void Delete(int id);      //видалення об'єкта по ID
        void Save();              //збереження змін
    }
}
