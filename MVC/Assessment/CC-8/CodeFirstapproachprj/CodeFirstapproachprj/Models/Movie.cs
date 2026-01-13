using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstapproachprj.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string DirectorName { get; set; }

        public DateTime DateOfRelease { get; set; }
    }
}