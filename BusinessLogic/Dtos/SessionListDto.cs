using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Dtos
{
    public class SessionListDto
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
     
        public int HallNumber { get; set; }
        public int SeatNumber { get; set; }


    }
}
