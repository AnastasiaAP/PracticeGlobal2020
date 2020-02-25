using System.Collections.Generic;
using DataAccessLayer.Interfaces;
using EntityDB.Models;

namespace DataAccessLayer.Repositories
{
    public class SqlSpecialtyRepository : IRepository<Specialty>
    {
        private readonly UniversityDBContext db;
        public SqlSpecialtyRepository()
        {
            this.db = new UniversityDBContext();
        }

        void IRepository<Specialty>.Create(Specialty item)
        {
            db.Specialty.Add(item);
        }

        void IRepository<Specialty>.Delete(int id)
        {
            var specialty = db.Specialty.Find(id);
            if (specialty != null) db.Specialty.Remove(specialty);
        }

        IEnumerable<Specialty> IRepository<Specialty>.GetAll()
        {
            return db.Specialty;
        }

        Specialty IRepository<Specialty>.GetById(int Id)
        {
            return db.Specialty.Find(Id);
        }

        void IRepository<Specialty>.Save()
        {
            db.SaveChanges();
        }

        void IRepository<Specialty>.Update(Specialty item)
        {
            db.Specialty.Update(item);
        }
    }
}
