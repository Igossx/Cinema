using Cinema.Entities.Enumerations;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateOfRelease { get; set; }
        public string TrailerUrl { get; set; }
        public string CoverImageUrl { get; set; }
        public MovieCategory Category { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime PlayingDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime PlayingTime { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
