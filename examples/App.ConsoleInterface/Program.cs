using App.Core.UseCases.SearchBlogPosts;
using App.Infrastructure;
using System;

namespace App.ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new SearchBlogPostsRequest(string.Empty, null,null);
            var outputBoundary = new SearchBlogPostsOutputBoundary();
            outputBoundary.OnResponseReceived += Console.WriteLine;
            var gateway = new SearchBlogPostsGateway();
            var usecase = new SearchBlogPostsInteractor(gateway);


            usecase.Execute(request, outputBoundary);

            Console.ReadKey();

        }
    }
}
