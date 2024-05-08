using AutoMapper;
using BusinessLogic.Dtos;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Mappers
{
    internal class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Hall, HallListDto>();
            CreateMap<Movie, MovieListDto>().ReverseMap();
            CreateMap<Seat, SeatListDto>();
            CreateMap<Session, SessionListDto>();
            CreateMap<Ticket, TicketListDto>().ReverseMap();
            CreateMap<User, UserListDto>();
        }
    }
}
