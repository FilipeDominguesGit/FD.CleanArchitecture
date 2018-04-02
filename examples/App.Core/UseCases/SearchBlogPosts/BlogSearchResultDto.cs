using System;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class BlogSearchResultDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
    }

}