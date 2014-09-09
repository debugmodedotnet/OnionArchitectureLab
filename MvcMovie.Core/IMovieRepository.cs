using System;
using System.Collections.Generic;
namespace MvcMovie.Core
{
   public interface IMovieRepository
    {
        void Add(Movie m);
        void Edit(Movie m);
        IEnumerable<Movie> GetMovies();
        void Remove(int id);
    }
}
