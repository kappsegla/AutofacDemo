using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutofacDemo.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [NotMapped]
        public bool Good { get; set; }

        public virtual ICollection<Course> Courses { get; set; }       
    }
}
