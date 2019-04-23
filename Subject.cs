using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ClassSubjects> ClassSubjects { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
