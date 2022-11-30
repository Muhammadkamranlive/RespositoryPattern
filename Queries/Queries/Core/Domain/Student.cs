using Queries.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries.Core.Domain
{
    [Table("Students")]
    public class Student:User
    {
        
        public Student()
        {
            Teachers= new HashSet<Teachers>();
            Courses= new HashSet<Course>();
        }
        public virtual ICollection<Teachers> Teachers { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
