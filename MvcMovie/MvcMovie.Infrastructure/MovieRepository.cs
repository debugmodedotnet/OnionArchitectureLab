using MvcMovie.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcMovie.Infrastructure
{
    public class MovieRepository : IMovieRepository, IDisposable
    {
        MovieDBContext db = new MovieDBContext();
        public IEnumerable<Movie> GetMovies()
        {
            
                return db.Movies;
            
        }

        public void Add(Movie m)
        {
          
                db.Movies.Add(m);
                db.SaveChanges();

           
        }

        public void Edit(Movie m)
        {
            
                db.Entry(m).State = EntityState.Modified;
                db.SaveChanges();

            
        }

        public void Remove(int id)
        {
                Movie movie = db.Movies.Find(id);
                db.Movies.Remove(movie);
                db.SaveChanges();

            
        }


        public void Dispose()
        {
            db.Dispose();

        }
    }
}
