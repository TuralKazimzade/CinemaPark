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
    public class UserService : IUserService
    {
        private readonly IUser _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUser userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserListDto>> GetUserListAsync()
        {
            return _mapper.Map<IEnumerable<UserListDto>>(await _userRepository.GetUserList());
        }
    }
}
