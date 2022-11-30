using Queries.Core.Domain;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Queries.Core.Domain
{
   
    public class Teachers
    {
        private Teachers teacher;
        public int Id { get; set; }
        public Teachers(User user)
        {
            
            Courses = new HashSet<Course>();
            Students = new HashSet<Student>();
        }

        public Teachers(Teachers teacher)
        {
            this.teacher = teacher;
        }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
