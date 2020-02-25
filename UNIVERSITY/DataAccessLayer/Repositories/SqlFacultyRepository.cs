using System.Collections.Generic;
using DataAccessLayer.Interfaces;
using EntityDB.Models;

namespace DataAccessLayer.Repositories
{
    public class SqlFacultyRepository : IRepository<Faculty>
    {
        private readonly UniversityDBContext db;

        public SqlFacultyRepository()
        {
            this.db = new UniversityDBContext();
        }

        public void Create(Faculty item)
        {
            db.Faculty.Add(item);
        }

        public void Delete(int id)
        {
            var faculty = db.Faculty.Find(id);
            if (faculty != null) db.Faculty.Remove(faculty);
        }                           

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Faculty item)
        {
            db.Faculty.Update(item);
        }

        public Faculty GetById(int Id)
        {
            return db.Faculty.Find(Id);
        }

        public IEnumerable<Faculty> GetAll()
        {
            return db.Faculty;
        }
    }
}
