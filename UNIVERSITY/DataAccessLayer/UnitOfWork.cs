using System;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using EntityDB.Models;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private UniversityDBContext db = new UniversityDBContext();
        IRepository<Faculty> IUnitOfWork.FacultyRepository => throw new NotImplementedException();
        IRepository<Department> IUnitOfWork.DepartmentRepository => throw new NotImplementedException();
        IRepository<Specialty> IUnitOfWork.SpecialtyRepository => throw new NotImplementedException();
        IRepository<Groupe> IUnitOfWork.GroupeRepository => throw new NotImplementedException();
        IRepository<Student> IUnitOfWork.StudentRepository => throw new NotImplementedException();

        private SqlFacultyRepository facultyRepository;
        private SqlDepartmentRepository departmentRepository;
        private SqlSpecialtyRepository specialtyRepository;
        private SqlGroupeRepository groupeRepository;
        private SqlStudentRepository studentRepository;

        private UnitOfWork()
        {

        }
       

        public SqlFacultyRepository Faculty
        {
            get
            {
                if (facultyRepository == null)
                    facultyRepository = new SqlFacultyRepository();
                return facultyRepository;
            }
        }
                
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        void IUnitOfWork.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnitOfWork.Save()
        {
            throw new NotImplementedException();
        }
    }
}
