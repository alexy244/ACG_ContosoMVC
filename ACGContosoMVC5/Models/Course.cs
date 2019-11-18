using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ACG_ContosoMVC5.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }

        [Required, StringLength(50)]
        public string Title { get; set; }

        [Required, Range(40, 360)]
        public int Credits { get; set; }

        // Relationships
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
