using FD.CleanArchitecture.Core.Boundary;
using FD.CleanArchitecture.Core.Interactor;
using System;
using System.Linq;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class SearchBlogPostsInteractor : IInteractor<SearchBlogPostsRequest, SearchBlogPostsResponse>
    {
        private readonly ISearchBlogPostsGateway _gateway;

        public SearchBlogPostsInteractor( ISearchBlogPostsGateway gateway,IOutputBoundary<SearchBlogPostsResponse> outputboundary) 
        {
            _gateway = gateway;
            OutputBoundary = outputboundary;
        }


        public void Execute(SearchBlogPostsRequest request)
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

                OutputBoundary.PublishSuccess(response);
            }
            catch (Exception e)
            {
                OutputBoundary.PublishError(e.Message);
            }
        }

        public IOutputBoundary<SearchBlogPostsResponse> OutputBoundary { get; set; }
    }
}