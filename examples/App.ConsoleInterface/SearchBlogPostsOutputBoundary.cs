using App.Core.UseCases.SearchBlogPosts;
using FD.CleanArchitecture.Core.Boundary;

namespace App.ConsoleInterface
{
    public class SearchBlogPostsOutputBoundary : IOutputBoundary<SearchBlogPostsResponse>
    {
        public delegate void OnResponse(string postrecord);
        public event OnResponse OnResponseReceived;

        public delegate void OnError(string error);
        public event OnError OnErrorReceived;


        public void PublishSuccess(SearchBlogPostsResponse response)
        {
            foreach (var blg in response.Post)
            {
                OnResponseReceived?.Invoke($"[{blg.Id}] Title: {blg.Title} Date: {blg.CreationDate.ToShortDateString()}");
            }
        }

        public void PublishError(string error)
        {
            OnErrorReceived?.Invoke(error);
        }
    }
}