using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Seat : ITable
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public bool IsAviable { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public Session Session { get; set; }
    }
}
