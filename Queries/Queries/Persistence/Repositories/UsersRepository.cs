using Queries.Core.Domain;
using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Persistence.Repositories
{
    public class UsersRepository:Repository<User> ,IUserRespository
    {
        public UsersRepository(LearningContext context) :base(context)
        {

        }

        public LearningContext PlutoContext
        {
            get { return Context as LearningContext; }
        }
    }
}
