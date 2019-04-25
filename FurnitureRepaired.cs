using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDb.Models
{
    public class FurnitureRepaired
    {
        public int Id { get; set; }
        public string ItemRepaired { get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }
        public DateTime RepairedOn { get; set; }
    }
}
