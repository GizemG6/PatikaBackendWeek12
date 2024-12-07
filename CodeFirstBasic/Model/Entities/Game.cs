using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBasic.Model.Entities
{
    public class Game
    {
        public int Id { get; set; } // Primary key
        public string Name { get; set; } // Game name
        public string Platform { get; set; } // Game platform
        public decimal Rating { get; set; } // Rating (0-10)
    }
}
