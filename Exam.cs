using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int CreatedById { get; set; }
        public string Type { get; set; }
        public DateTime TakenOn { get; set; }
        public string File { get; set; }
        public int TotalMarks { get; set; }
        public string Session { get; set; }

        public virtual ICollection<Marks> Marks { get; set; }
        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Staff CreatedBy { get; set; }
    }
}
