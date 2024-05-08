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
    public class SeatRepository : GenericRepository<Seat>, ISeat
    {
        public SeatRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        public async Task<IEnumerable<Seat>> GetSeatList()
        {
           var seats = await Table.Include(x=>x.Hall).ToListAsync();
            return seats;
            
                
        }
    }
}
