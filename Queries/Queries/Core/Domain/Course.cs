using Queries.Core.Domain;
using System.Collections.Generic;

namespace Queries.Core.Domain
{
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
            Students = new HashSet<Student>();
            Teachers= new HashSet<Teachers>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }
        public int TeacherId { get; set; }

        public virtual ICollection<Teachers> Teachers { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Category Category { get; set; }
        public Cover Cover { get; set; }

        public bool IsBeginnerCourse
        {
            get { return Level == 1; }
        }
    }
}
