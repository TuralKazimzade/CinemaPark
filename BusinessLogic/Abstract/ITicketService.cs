using BusinessLogic.Dtos;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstract
{
   public interface ITicketService
    {
        Task AddAsync(TicketListDto ticket);
        Task<IEnumerable<Ticket>> GetTickets();
        Task<IEnumerable<TicketListDto>> GetTicketListAsync();
    }
}
