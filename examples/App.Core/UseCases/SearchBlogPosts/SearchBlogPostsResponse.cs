using FD.CleanArchitecture.Core.Boundary;
using System.Collections.Generic;

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
}