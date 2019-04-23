using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Marks
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int MarksObt { get; set; }
        public int MarkedById { get; set; }
        public DateTime MarkedOn { get; set; }

        public virtual Student Student { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Staff MarkedBy { get; set; }
    }
}
