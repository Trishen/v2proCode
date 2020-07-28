using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace v2proCode.Models
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }

        [Required(ErrorMessage ="Enter a Subject Name")]
        [Display(Name ="Subject Name")]
        public string SubjectName { get; set; }

        //  public virtual ICollection<Course_material> Course_Materials { get; set; }
        //  public virtual ICollection<Subject_Report> Subject_Report { get; set; }
        //  public virtual ICollection<Class> Class { get; set; }

    }
}