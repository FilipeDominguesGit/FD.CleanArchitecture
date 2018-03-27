using App.Core.UseCases.SearchBlogPosts;
using App.Infrastructure;
using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using FD.CleanArchitecture.Core.Interactor;

namespace App.Api.Installers
{
    public class UseCaseInstaller:IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<TypedFactoryFacility>();

            container.Register(Component.For<ISearchBlogPostsGateway>()
                .ImplementedBy<SearchBlogPostsGateway>().LifeStyle.Transient);

            container.Register(Component.For<IInteractor<SearchBlogPostsRequest, SearchBlogPostsResponse>>()
                .ImplementedBy<SearchBlogPostsInteractor>().LifeStyle.Transient);

            container.Register(Component.For<IInteractorsFactory>().AsFactory());
        }
    }
}