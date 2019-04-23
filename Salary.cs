using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int StaffId { get; set; }
        public DateTime Month { get; set; }
        public int Amount { get; set; }
        public DateTime GivenOn { get; set; }
        public string GivenBy { get; set; }

        public virtual Staff Staff { get; set; }
    }
}
