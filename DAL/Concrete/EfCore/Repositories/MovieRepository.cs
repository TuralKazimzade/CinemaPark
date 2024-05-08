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
  public class MovieRepository : GenericRepository<Movie>, IMovie
    {
        public MovieRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

    }
}
