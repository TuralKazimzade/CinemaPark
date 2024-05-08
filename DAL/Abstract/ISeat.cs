using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
   public interface ISeat:IGeneric<Seat>
    {
        Task<IEnumerable<Seat>> GetSeatList();
    }
}
