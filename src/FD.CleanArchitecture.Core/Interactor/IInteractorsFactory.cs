using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    /// <summary>
    /// Interactor factory
    /// </summary>
    public interface IInteractorsFactory
    {
        IInteractor<TRequest, TResponse> Create<TRequest,TResponse>(IOutputBoundary<TResponse> outputboundary) where TResponse : IResponse where TRequest : IRequest;

        ISimpleInteractor<TRequest, TResponse> Create<TRequest, TResponse>() where TResponse : IResponse where TRequest : IRequest;
    }
}