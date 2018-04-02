using App.Core.UseCases.SearchBlogPosts;
using Castle.Windsor;
using Castle.Windsor.Installer;
using FD.CleanArchitecture.Core.Interactor;
using System;
using System.Reflection;

namespace App.ConsoleInterface
{
    class Program 
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Install(FromAssembly.InThisApplication(Assembly.GetEntryAssembly()));

            var factory = container.Resolve<IInteractorsFactory>();

            var outputboundary = new ConsolePresenter();
            var request = new SearchBlogPostsRequest(string.Empty, null, null);
            var usecase = factory.Create<SearchBlogPostsRequest, SearchBlogPostsResponse>(outputboundary);
            usecase.Execute(request);

            Console.ReadKey();

        }
    }
}
