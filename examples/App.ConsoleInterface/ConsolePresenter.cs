using System;
using App.Core.UseCases.SearchBlogPosts;
using FD.CleanArchitecture.Core.Boundary;

namespace App.ConsoleInterface
{
    public class ConsolePresenter : IOutputBoundary<SearchBlogPostsResponse>
    {
      

        public void PublishSuccess(SearchBlogPostsResponse response)
        {
            foreach (var blg in response.Post)
            {
                Console.WriteLine($"[{blg.Id}] Title: {blg.Title} Date: {blg.CreationDate.ToShortDateString()}");
            }
        }

        public void PublishError(string error)
        {
            Console.WriteLine(error);
        }
    }
}