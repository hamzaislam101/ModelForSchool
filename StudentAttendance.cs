using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class StudentAttendance
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Date { get; set; }
        public DateTime AddedAt { get; set; }

        public virtual Student Student { get; set; }
    }
}
