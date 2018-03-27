using System;
using System.Linq;
using FD.CleanArchitecture.Core.Boundary;
using FD.CleanArchitecture.Core.Interactor;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class SearchBlogPosts : IInteractor<SearchBlogPostsRequest, SearchBlogPostsResponse>
    {
        private readonly ISearchBlogPostsGateway _gateway;

        public SearchBlogPosts( ISearchBlogPostsGateway gateway) 
        {
            _gateway = gateway;
        }

        public void Execute(SearchBlogPostsRequest request, IOutputBoundary<SearchBlogPostsResponse> outputBoundary)
        {
            try
            {
                var blogposts = _gateway.Search(request.Search, request.NumberOfRecords, request.Page);

                var response = new SearchBlogPostsResponse(
                                    blogposts.Select(p => new BlogSearchResultDto()
                                    {
                                        CreationDate = p.CreationDate,
                                        Id = p.Id,
                                        Title = p.Title
                                    })
                                );

                outputBoundary.PublishSuccess(response);
            }
            catch (Exception e)
            {
                outputBoundary.PublishError(e.Message);
            }
        }
    }
}