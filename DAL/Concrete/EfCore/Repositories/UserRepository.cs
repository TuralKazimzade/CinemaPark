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
    public class UserRepository : GenericRepository<User>, IUser
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<IEnumerable<User>> GetUserList()
        {
            var users = await Table.Include(x=>x.Ticket).ToListAsync();
            return users;
        }
    }
}
