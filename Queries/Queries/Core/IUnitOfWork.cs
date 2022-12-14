using Queries.Core.Repositories;
using System;

namespace Queries.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        ITeacherRepository Teacher { get; }
        IUserRespository User { get; }
        int Complete();
    }
}