using System;
using System.Linq;
using FD.CleanArchitecture.Core.Boundary;
using FD.CleanArchitecture.Core.Interactor;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class SearchBlogPosts : Interactor<SearchBlogPostsRequest, SearchBlogPostsResponse>
    {
        private readonly ISearchBlogPostsGateway _gateway;

        public SearchBlogPosts(IOutputBoundary<SearchBlogPostsResponse> outputBoundary, ISearchBlogPostsGateway gateway) : base(outputBoundary)
        {
            _gateway = gateway;
        }

        public override void Execute(SearchBlogPostsRequest request)
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
    }
}