using FD.CleanArchitecture.Core.Boundary;

namespace App.Core.UseCases.SearchBlogPosts
{
    public class SearchBlogPostsRequest : IRequest
    {
        public string Search { get; }
        public int NumberOfRecords { get; }
        public int Page { get; }

        public SearchBlogPostsRequest(string search, int? numberOfRecords, int? page)
        {
            Search = search;
            NumberOfRecords = numberOfRecords ?? 20;
            Page = page ?? 1;
        }
    }
}