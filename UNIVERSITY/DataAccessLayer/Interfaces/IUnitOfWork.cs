using EntityDB.Models;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Faculty> FacultyRepository { get; }
        IRepository<Department> DepartmentRepository { get; }
        IRepository<Specialty> SpecialtyRepository { get; }
        IRepository<Groupe> GroupeRepository { get; }
        IRepository<Student> StudentRepository { get; }

        void Dispose();
        int Save();
    }
}
