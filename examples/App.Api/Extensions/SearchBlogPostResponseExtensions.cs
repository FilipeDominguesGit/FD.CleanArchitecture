using App.Api.ViewModel;
using App.Core.UseCases.SearchBlogPosts;
using System.Collections.Generic;
using System.Linq;

namespace App.Api.Extensions
{
    public static class SearchBlogPostResponseExtensions
    {
        public static IEnumerable<SearchBlogPostResultViewModel> ToViewModel(this SearchBlogPostsResponse response)
        {
            return response.Post.Select(bpr => new SearchBlogPostResultViewModel()
            {
                Title = bpr.Title,
                CreationDate = bpr.CreationDate,
                Id = bpr.Id
            });
        }
    }
}