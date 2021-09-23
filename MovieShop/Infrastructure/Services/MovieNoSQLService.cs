﻿using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieNoSQLService : IMovieService
    {
        public IEnumerable<MovieCardResponseModel> Get30HighestGrossingMovies()
        {
            var movies = new List<MovieCardResponseModel>
            {

                new MovieCardResponseModel {Id =1, Title="Inception", PosterUrl="Inception.jpg",Revenue=825532764},
                new MovieCardResponseModel {Id =2, Title="Interstellar", PosterUrl="Interstellar.jpg",Revenue=825532764},
                new MovieCardResponseModel {Id =3, Title="The Dark Knight", PosterUrl="The_Dark_Knight.jpg",Revenue=825532764}
            };
            return movies;
        }

    }
}
