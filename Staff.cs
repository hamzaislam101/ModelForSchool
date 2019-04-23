using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string CNIC { get; set; }
        public DateTime DOB { get; set; }
        public DateTime RegisteredOn { get; set; }
        public string Type { get; set; }
        
        public virtual ICollection<Salary> Salary { get; set; }
        public virtual ICollection<ClassSubjects> ClassSubjects { get; set; }
        public virtual ICollection<StaffAttendance> StaffAttendance { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
    }
}
