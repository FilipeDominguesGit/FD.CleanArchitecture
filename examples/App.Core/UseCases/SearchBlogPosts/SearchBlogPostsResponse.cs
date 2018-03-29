using System;
using System.Collections.Generic;
using FD.CleanArchitecture.Core.Boundary;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class SearchBlogPostsResponse : IResponse
    {
        public IEnumerable<BlogSearchResultDto>  Post { get; }

        public SearchBlogPostsResponse(IEnumerable<BlogSearchResultDto> post)
        {
            Post = post;
        }
    }

    public class BlogSearchResultDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreationDate { get; set; }
    }

}