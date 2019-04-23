using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassTeacherId { get; set; }
        public int RoomId { get; set; }

        public virtual Staff ClassTeacher { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<ClassSubjects> ClassSubjects { get; set; }
        public virtual ICollection<TimeTable> TimeTables { get; set; }

    }
}
