using EFmodelCHECK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb.Models
{
    public class FurnitureRemoved
    {
        public int Id { get; set; }
        public string ItemRemoved { get; set; }
        public int Quantity { get; set; }
        public int RoomId { get; set; }
        public DateTime RemovedOn { get; set; }

        public virtual Room Room { get; set; }
    }
}
