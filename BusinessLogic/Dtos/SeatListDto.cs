using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Dtos
{
    public class SeatListDto
    {
        public int Id { get; set; }
        public int SeatNumber { get; set; }
        public bool IsAviable { get; set; }
        public int SeatCount { get; set; }

    }
}
