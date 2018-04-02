using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    /// <inheritdoc />
    /// <summary>
    /// Simple interactor. 
    /// No outputboundary. Returns the ResponseModel to the Interactor caller. 
    /// </summary>
    /// <typeparam name="TRequest">Request Model</typeparam>
    /// <typeparam name="TResponse">Response Model</typeparam>
    public interface ISimpleInteractor<in TRequest, out TResponse> : ISimpleInputBoundary<TRequest,TResponse> 
        where TResponse : IResponse 
        where TRequest : IRequest
    {
        
    }
}