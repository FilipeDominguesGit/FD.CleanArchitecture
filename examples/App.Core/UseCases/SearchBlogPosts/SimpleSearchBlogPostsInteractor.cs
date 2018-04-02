using FD.CleanArchitecture.Core.Interactor;
using System;
using System.Linq;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class SimpleSearchBlogPostsInteractor : ISimpleInteractor<SearchBlogPostsRequest,SearchBlogPostsResponse>
    {
        private readonly ISearchBlogPostsGateway _gateway;

        public SimpleSearchBlogPostsInteractor(ISearchBlogPostsGateway gateway)
        {
            _gateway = gateway;
        }

        public SearchBlogPostsResponse Execute(SearchBlogPostsRequest request)
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
                return response;
            }
            catch (Exception e)
            {
                //log
                throw;
            }
        }
    }
}