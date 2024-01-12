using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private static readonly List<Movie> movies = new List<Movie>()
    {
        new() {Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16)},
        new() {Id = 2, Title = "The Dark Knight", Genre = "Action", ReleaseDate = new DateTime(2008, 7, 18)},
        new() {Id = 3, Title = "Interstellar", Genre = "Sci-Fi", ReleaseDate = new DateTime(2014, 11, 7)},
        new() {Id = 4, Title = "Shawshank Redemption", Genre = "Drama", ReleaseDate = new DateTime(1994, 9, 10)},
        new() {Id = 5, Title = "Forrest Gump", Genre = "Drama", ReleaseDate = new DateTime(1994, 7, 6)},
    };

        [HttpGet(Name = "GetMovies")]
        public IEnumerable<Movie> Get()
        {
            return movies;
        }
    }
}