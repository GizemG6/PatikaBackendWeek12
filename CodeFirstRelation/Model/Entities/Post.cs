using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Model.Entities
{
    public class Post
    {
        // Primary key
        public int Id { get; set; }

        // Title of the post
        public string Title { get; set; }

        // Content of the post
        public string Content { get; set; }

        // Foreign key: Author of the post
        public int UserId { get; set; }

        // Navigation property: Each post belongs to one user
        public User User { get; set; }
    }
}
