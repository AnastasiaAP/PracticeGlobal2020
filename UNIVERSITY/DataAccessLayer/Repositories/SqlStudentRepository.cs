using System.Collections.Generic;
using DataAccessLayer.Interfaces;
using EntityDB.Models;

namespace DataAccessLayer.Repositories
{
    public class SqlStudentRepository : IRepository<Student>
    {
        private readonly UniversityDBContext db;
        public SqlStudentRepository()
        {
            this.db = new UniversityDBContext();
        }

        void IRepository<Student>.Create(Student item)
        {
            db.Student.Add(item);
        }

        void IRepository<Student>.Delete(int id)
        {
            var student = db.Student.Find(id);
            if (student != null) db.Student.Remove(student);
        }

        IEnumerable<Student> IRepository<Student>.GetAll()
        {
            return db.Student;
        }

        Student IRepository<Student>.GetById(int Id)
        {
            return db.Student.Find(Id);
        }

        void IRepository<Student>.Save()
        {
            db.SaveChanges();
        }

        void IRepository<Student>.Update(Student item)
        {
            db.Student.Update(item);
        }
    }
}
