using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class StaffAttendance
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public DateTime Date { get; set; }
        public DateTime UploadedOn { get; set; }
        public int UploadedById { get; set; }

        public virtual Staff Staff { get; set; }
        public virtual User UploadedBy { get; set; }
    }
}
