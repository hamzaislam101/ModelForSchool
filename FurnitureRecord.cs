using EFmodelCHECK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb.Models
{
    public class FurnitureRecord
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public DateTime AddedOn { get; set; }
        public int RoomId { get; set; }

        public virtual Room Room { get; set; }
    }
}
