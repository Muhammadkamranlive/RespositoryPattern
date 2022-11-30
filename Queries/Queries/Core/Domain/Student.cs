using Queries.Core.Domain;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    
    public class Student
    {
        public int Id { get; set; }
        public Student(User user)
        {
            Teachers= new HashSet<Teachers>();
            Courses= new HashSet<Course>();
        }
        public virtual ICollection<Teachers> Teachers { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
