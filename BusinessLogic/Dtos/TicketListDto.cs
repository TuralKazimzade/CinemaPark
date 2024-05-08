using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Dtos
{
    public class TicketListDto
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public int Price { get; set; }
        public string PurchaseDate { get; set; }
    }
}
