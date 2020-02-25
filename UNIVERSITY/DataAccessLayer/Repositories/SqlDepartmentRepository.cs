using System.Collections.Generic;
using DataAccessLayer.Interfaces;
using EntityDB.Models;

namespace DataAccessLayer.Repositories
{
    public class SqlDepartmentRepository : IRepository<Department>
    {
        private readonly UniversityDBContext db;
        public SqlDepartmentRepository()
        {
            this.db = new UniversityDBContext();
        }

        void IRepository<Department>.Create(Department item)
        {
            db.Department.Add(item);
        }

        void IRepository<Department>.Delete(int id)
        {
            var department = db.Department.Find(id);
            if (department != null) db.Department.Remove(department);
        }

        IEnumerable<Department> IRepository<Department>.GetAll()
        {
            return db.Department;
        }

        Department IRepository<Department>.GetById(int Id)
        {
            return db.Department.Find(Id);
        }

        void IRepository<Department>.Save()
        {
            db.SaveChanges();
        }

        void IRepository<Department>.Update(Department item)
        {
            db.Department.Update(item);
        }
    }
}
