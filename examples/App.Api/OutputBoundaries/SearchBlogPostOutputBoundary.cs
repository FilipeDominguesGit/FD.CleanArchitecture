using System;
using System.Collections.Generic;
using System.Linq;
using App.Api.ViewModel;
using App.Core.UseCases.SearchBlogPosts;
using FD.CleanArchitecture.Core.Boundary;

namespace App.Api.OutputBoundaries
{
    public class SearchBlogPostOutputBoundary : IOutputBoundary<SearchBlogPostsResponse>
    {
        public IEnumerable<SearchBlogPostResultViewModel> Result { get; set; }
        public string ErrorMessage { get; set; }
        public bool Success => string.IsNullOrWhiteSpace(ErrorMessage);

        public void PublishSuccess(SearchBlogPostsResponse response)
        {
            Result = response.Post.Select(bpr=>new SearchBlogPostResultViewModel()
            {
                Title = bpr.Title,
                CreationDate = bpr.CreationDate,
                Id = bpr.Id
            });
        }

        public void PublishError(string error)
        {
            ErrorMessage = error;
        }
    }

   
}