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
    public class HallService : IHallService
    {
        private readonly IHall _hallRepository;
        private readonly IMapper _mapper;

        public HallService(IHall hallRepository, IMapper mapper)
        {
            _hallRepository = hallRepository;
            _mapper = mapper;
        }

        public async Task AddAsync(Hall hall)
        {
            await _hallRepository.AddAsync(hall);
            
        }

        public   async Task<IEnumerable<HallListDto>> GetHallListAsync()
        {                
            var hallList = _mapper.Map<IEnumerable<HallListDto>>(await _hallRepository.GetHallList());
            return hallList;
        }

        public async Task<IEnumerable<Hall>> GetHalls()
        {
            return await _hallRepository.GetAllAsync();
        }

        public Task Update(Hall hall)
        {
            throw new NotImplementedException();

        }
    }
}
