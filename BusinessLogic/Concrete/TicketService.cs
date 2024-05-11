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

        public async Task AddAsync(TicketListDto ticket)
        {
            if(ticket is null)
            {
                throw new Exception("Ticket is null");
            }
            await _ticketRepository.AddAsync(_mapper.Map<Ticket>(ticket));
            await _ticketRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<TicketListDto>> GetTicketListAsync()
        {
            return _mapper.Map<IEnumerable<TicketListDto>>(await _ticketRepository.GetAllAsync());
        }

        public async Task<IEnumerable<Ticket>> GetTickets()
        {
            return await _ticketRepository.GetAllAsync();
        }
    }
}
