using MovieWebApp.Entity;

namespace MovieWebApp.Services
{
    public interface MovieInterface
    {
        Movie Insert(Movie movie);

        Movie Update(Movie movie);
        Movie Delete(int id);

        List<Movie> GetAll();
        
    }
}
