using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string  Email { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

    }
}
