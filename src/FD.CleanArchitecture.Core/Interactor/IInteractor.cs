using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    public interface IInteractor<in TRequest, out TResponse> : IInputBoundary<TRequest,TResponse> 
        where TRequest : IRequest 
        where TResponse : IReponse
    {
    }
}