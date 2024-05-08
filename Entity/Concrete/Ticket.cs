using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Ticket : ITable
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public User User { get; set; }
    }
}
