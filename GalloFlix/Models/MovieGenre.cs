using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalloFlix.Models
{
    public class MovieGenre
    {
        public int MovieId {get; set;}
        public Movie Movie {get; set;}
        public byte GenreId {get; set;}
        public Genre Genre {get; set;}
    }
}