using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Model.Entities
{
    public class User
    {
        // Primary key
        public int Id { get; set; }

        // Username of the user
        public string Username { get; set; }

        // Email of the user
        public string Email { get; set; }

        // Navigation property: One user can have many posts
        public ICollection<Post> Posts { get; set; }
    }
}
