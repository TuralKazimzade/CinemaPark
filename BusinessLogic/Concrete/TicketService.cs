using AutoMapper;
using BusinessLogic.Abstract;
using BusinessLogic.Dtos;
using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Concrete
{
    public class TicketService : ITicketService
    {
        private readonly ITicket _ticketRepository;
        private readonly IMapper _mapper;

        public TicketService(ITicket ticketRepository,IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TicketListDto>> GetTicketListAsync()
        {
            return _mapper.Map<IEnumerable<TicketListDto>>(await _ticketRepository.GetAllAsync());
        }
    }
}
