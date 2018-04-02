using App.Core.Entities;
using App.Core.UseCases.SearchBlogPosts;
using System;
using System.Collections.Generic;

namespace App.Infrastructure
{
    public class SearchBlogPostsGateway : ISearchBlogPostsGateway
    {
        public IEnumerable<Post> Search(string requestSearch, int requestNumberOfRecords, int requestPage)
        {
            return new List<Post>()
            {
                new Post()
                {
                    Id = Guid.NewGuid(),
                    CreationDate = DateTime.Now.AddDays(-1),
                    Title = "Title",
                    Comments = new List<Comment>(),
                    Content = "Post content"
                },
                new Post()
                {
                    Id = Guid.NewGuid(),
                    CreationDate = DateTime.Now.AddDays(-1),
                    Title = "Title 2",
                    Comments = new List<Comment>(),
                    Content = "Another Post content"
                }
            };
        }
    }
}
