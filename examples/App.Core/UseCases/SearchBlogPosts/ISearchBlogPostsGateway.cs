using System.Collections.Generic;
using App.Core.Entities;

namespace App.Core.UseCases.SearchBlogPosts
{
    public interface ISearchBlogPostsGateway
    {
        IEnumerable<Post> Search(string requestSearch, int requestNumberOfRecords, int requestPage);
    }
}