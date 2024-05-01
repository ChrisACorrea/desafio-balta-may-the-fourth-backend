using AutoMapper;
using MayTheFourth.Entities;
using MayTheFourth.Services.Dto;
using MayTheFourth.Services.ViewModels;
using MayTheFourth.Utils.Paging;

namespace MayTheFourth.Services.Mappers.Profiles
{
    public class ViewToModelMovieProfile: Profile
    {
        public ViewToModelMovieProfile()
        {
            CreateMap<MovieVM, Movie>();
            CreateMap<MovieVM, ListPlanetMovies>();
            CreateMap<MovieVM, ListStarshipMovies>();
            CreateMap<MovieVM, ListVehicleMovies>();
            CreateMap<MovieVM, ListCharacterMovies>();
            CreateMap<MovieVM, ListMovies>();

            CreateMap<PageListResult<MovieVM>, PageListResult<Movie>>();
            CreateMap<PageListResult<MovieVM>, PageListResult<ListPlanetMovies>>();
            CreateMap<PageListResult<MovieVM>, PageListResult<ListStarshipMovies>>();
            CreateMap<PageListResult<MovieVM>, PageListResult<ListVehicleMovies>>();
            CreateMap<PageListResult<MovieVM>, PageListResult<ListCharacterMovies>>();
            CreateMap<PageListResult<MovieVM>, PageListResult<ListMovies>>();
        }
    }
}
