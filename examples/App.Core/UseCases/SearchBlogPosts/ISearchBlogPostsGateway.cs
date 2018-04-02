using App.Core.Entities;
using System.Collections.Generic;

namespace App.Core.UseCases.SearchBlogPosts
{
    public interface ISearchBlogPostsGateway
    {
        IEnumerable<Post> Search(string requestSearch, int requestNumberOfRecords, int requestPage);
    }
}