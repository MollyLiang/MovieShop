using System;
using System.Collections.Generic;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public IEnumerable<MovieCardResponseModel> Get30HighestiGrossingMovies()
        {
            var repo = new MovieRepository();

           
            var movies = repo.Get30HighestGrossingMovies();
            var moviesCardResponseModel = new List<MovieCardResponseModel>();

            
            foreach (var movie in movies)
            {
                moviesCardResponseModel.Add(new MovieCardResponseModel { Id = movie.Id, PosterUrl = movie.PosterUrl });
            }
          
            return moviesCardResponseModel;
        }
    }
}
