using Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Interfaces
{
    public interface IMovieRepository
    {
        void Update(Movie movie);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<Movie>> GetMoviesAsync();
        Task<Movie> GetMovieByIdAsync(int id);
        Task<Movie> GetMovieByTitleAsync(string title);
    }
}
