using MovieWebApp.Entity;
using MovieWebApp.Repository;

namespace MovieWebApp.Services
{
    public class MovieImpl : MovieInterface
    {
        private readonly MovieContext _context = new MovieContext();

        public Movie Delete(int id)
        {
            using (var context = new MovieContext()) 
            { 
                var mov = context.Movies.find(id);
                context.Movies.Remove(mov);
                context.SaveChanges();
                return mov;
            }
        }

        public List<Movie> GetAll()
        {
            var mod=_context.Movies.ToList();
            return mod;
        }

        public Movie Insert(Movie movie)
        {
            using (var context = new MovieContext())
            { 
                var mov = context.Movies.Add(movie);
                context.SaveChanges();
                return movie;
            }
        }

        public Movie Update(Movie movie)
        {
            using (var context = new MovieContext())
            {
                var mod = context.Movies.Update(movie);
                context.SaveChanges();
                return movie;
            }

        }
    }
}
