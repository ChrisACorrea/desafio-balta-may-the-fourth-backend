using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles
{
    public class ModelToViewMovieProfile: Profile
    {
        public ModelToViewMovieProfile()
        {
            CreateMap<Movie, MovieVM>();
            CreateMap<Movie, ListPlanetMovies>();
            CreateMap<Movie, ListStarshipMovies>();
            CreateMap<Movie, ListVehicleMovies>();
            CreateMap<Movie, ListCharacterMovies>();
            CreateMap<Movie, ListMovies>();

            CreateMap<PageListResult<Movie>, PageListResult<MovieVM>>();
            CreateMap<PageListResult<Movie>, PageListResult<ListPlanetMovies>>();
            CreateMap<PageListResult<Movie>, PageListResult<ListStarshipMovies>>();
            CreateMap<PageListResult<Movie>, PageListResult<ListVehicleMovies>>();
            CreateMap<PageListResult<Movie>, PageListResult<ListCharacterMovies>>();
            CreateMap<PageListResult<Movie>, PageListResult<ListMovies>>();
        }
    }
}
