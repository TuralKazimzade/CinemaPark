using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
   public class Hall : ITable
    {
        public int Id { get; set; }
        public int HallNumber { get; set; }
        public int SeatCount { get; set; }
        public ICollection<Session> Session { get; set; }
        public ICollection<Seat> Seats { get; set; }
    }
}
