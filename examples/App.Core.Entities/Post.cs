using System;
using System.Collections.Generic;

namespace App.Core.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
