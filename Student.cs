using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string BForm { get; set; }
        public string CNIC { get; set; }
        public DateTime DOB { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int RollNumber { get; set; }
        public int ClassId { get; set; }
        public string RegisteredBy { get; set; }

        public virtual Class Class { get; set; }
        public virtual ICollection<Fees> Fees { get; set; }
        public virtual ICollection<Marks> Marks { get; set; }
        public virtual ICollection<StudentAttendance> StudentAttendance { get; set; }

    }
}
