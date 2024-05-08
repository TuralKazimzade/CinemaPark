using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Movie : ITable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Director { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string Description { get; set; }
        public ICollection <Session> Sessions { get; set; }    
    }
}
