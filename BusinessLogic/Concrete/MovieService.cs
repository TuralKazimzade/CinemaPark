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
    public class MovieService : IMovieService
    {
        private readonly IMovie _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovie movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }

        public async Task AddMovieAsync(MovieListDto movieList)
        {
            var movie =  _mapper.Map<Movie>(movieList);
           var result = await _movieRepository.AddAsync(movie);

            if(result is false)
            {
                throw new Exception("Movie can't added");
            }
           await _movieRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<MovieListDto>> GetMovieListAsync()
        {
            return _mapper.Map<IEnumerable<MovieListDto>>(await _movieRepository.GetAllAsync());
        }
     
    }
}
