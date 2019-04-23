using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmodelCHECK.Models
{
    public class ClassFurniture
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int Chairs { get; set; }
        public int Tables { get; set; }
        public int Lights { get; set; }
        public int Fans { get; set; }

        public virtual Room Room { get; set; }
    }
}
