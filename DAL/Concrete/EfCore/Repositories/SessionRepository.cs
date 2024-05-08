using DAL.Abstract;
using DAL.Concrete.EfCore.Contexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore.Repositories
{
    public class SessionRepository : GenericRepository<Session>, ISession
    {
        public SessionRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<Session>> GetSessionList()
        {
            var sessions = await Table
                .Include(x=>x.Movie)
                .Include(x=>x.Seat).Include(x=>x.Hall)
                .ToListAsync();
            return sessions;
        }
    }
}
