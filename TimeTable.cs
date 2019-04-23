using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class TimeTable
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string File { get; set; }
        public string Session { get; set; }
        public int Version { get; set; }
        public DateTime ImplementedOn { get; set; }

        public Class Class { get; set; }
    }
}
