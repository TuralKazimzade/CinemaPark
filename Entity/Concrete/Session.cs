using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Session : ITable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int HallId { get; set; }
        public Hall Hall { get; set; }
        public int SeatId { get; set; }
        public Seat Seat { get; set; }
    }
}
