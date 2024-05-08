using DAL.Abstract;
using DAL.Concrete.EfCore.Contexts;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore.Repositories
{
    public class HallRepository : GenericRepository<Hall>, IHall
    {
        public HallRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            
        }

        public async Task<IEnumerable<Hall>> GetHallList()
        {
            var halls = await Table.ToListAsync(); 
            return halls;
        }
    }
}
