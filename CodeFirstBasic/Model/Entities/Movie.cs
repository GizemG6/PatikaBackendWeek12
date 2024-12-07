using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBasic.Model.Entities
{
    public class Movie
    {
        public int Id { get; set; } // Primary key
        public string Title { get; set; } // Movie title
        public string Genre { get; set; } // Movie genre
        public int ReleaseYear { get; set; } // Release year
    }
}
