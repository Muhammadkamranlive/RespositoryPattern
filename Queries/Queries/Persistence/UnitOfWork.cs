using Queries.Core;
using Queries.Core.Repositories;
using Queries.Persistence.Repositories;

namespace Queries.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LearningContext _context;

        public UnitOfWork(LearningContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Teacher = new TeacherRepository(_context);
            User= new UsersRepository(_context);
            
        }

        public ICourseRepository Courses { get; private set; }
        public ITeacherRepository Teacher { get; private set; }

        public IUserRespository User { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}