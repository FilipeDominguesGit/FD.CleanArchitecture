using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    public interface IInteractorsFactory
    {
        IInteractor<TRequest, TResponse> Create<TRequest,TResponse>() where TResponse : IReponse where TRequest : IRequest;
    }
}