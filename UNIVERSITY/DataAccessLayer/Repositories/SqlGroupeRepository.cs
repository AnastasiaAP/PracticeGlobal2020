using System.Collections.Generic;
using DataAccessLayer.Interfaces;
using EntityDB.Models;

namespace DataAccessLayer.Repositories
{
    public class SqlGroupeRepository : IRepository<Groupe>
    {
        private readonly UniversityDBContext db;
        public SqlGroupeRepository()
        {
            this.db = new UniversityDBContext();
        }

        void IRepository<Groupe>.Create(Groupe item)
        {
            db.Groupe.Add(item);
        }

        void IRepository<Groupe>.Delete(int id)
        {
            var groupe = db.Groupe.Find(id);
            if (groupe != null) db.Groupe.Remove(groupe);
        }

        IEnumerable<Groupe> IRepository<Groupe>.GetAll()
        {
            return db.Groupe;
        }

        Groupe IRepository<Groupe>.GetById(int Id)
        {
            return db.Groupe.Find(Id);
        }

        void IRepository<Groupe>.Save()
        {
            db.SaveChanges();
        }

        void IRepository<Groupe>.Update(Groupe item)
        {
            db.Groupe.Update(item);
        }
    }
}