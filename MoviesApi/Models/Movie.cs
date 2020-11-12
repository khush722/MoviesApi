using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Models
{
    public class Movie // model class
    {
        // PK
        [Key]
        public int Id { get; set; }
        // name of the movie
        public string Name { get; set; }
        // imdb rating
        public int Rating { get; set; }
        // released date
        public string Released { get; set; }
        // a small plot about movie
        public string Plot { get; set; }

    }
}
