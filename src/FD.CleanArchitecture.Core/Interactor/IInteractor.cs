using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    public interface IInteractor<in TRequest, in TResponse> : IInputBoundary<TRequest> 
        where TRequest : IRequest 
        where TResponse : IReponse
    {
        IOutputBoundary<TResponse> OutputBoundary { get; }
    }
}