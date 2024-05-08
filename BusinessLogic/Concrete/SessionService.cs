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
    public class SessionService : ISessionService
    {
        private readonly ISession _sessionRepository;
        private readonly IMapper _mapper;

        public SessionService(ISession sessionRepository,IMapper mapper)
        {
            _sessionRepository = sessionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<SessionListDto>> GetSessionListAsync()
        {
            return _mapper.Map<IEnumerable<SessionListDto>>(await _sessionRepository.GetSessionList());    
        }
    }
}
