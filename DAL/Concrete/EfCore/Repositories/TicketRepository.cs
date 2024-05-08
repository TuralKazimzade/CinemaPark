using DAL.Abstract;
using DAL.Concrete.EfCore.Contexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicket
    {
        public TicketRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
