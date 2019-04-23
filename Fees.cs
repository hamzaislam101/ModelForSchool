using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class Fees
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public DateTime Month { get; set; }
        public int Amount { get; set; }
        public int AcceptedById { get; set; }
        public DateTime SubmittedOn { get; set; }

        public virtual User AcceptedBy { get; set; }
        public virtual Student Student { get; set; }
    }
}
