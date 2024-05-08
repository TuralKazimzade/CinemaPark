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
    public class SeatService:ISeatService
    {
        private readonly ISeat _seatRepository;
        private readonly IMapper _mapper;

        public SeatService(ISeat seatRepository,IMapper mapper )
        {
            _seatRepository = seatRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SeatListDto>> GetSeatListAsync()
        {
            return _mapper.Map<IEnumerable<SeatListDto>>(await _seatRepository.GetSeatList());    
            
        }
    }
}
