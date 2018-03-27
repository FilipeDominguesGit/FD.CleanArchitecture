using System;

namespace App.Core.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
    }
}