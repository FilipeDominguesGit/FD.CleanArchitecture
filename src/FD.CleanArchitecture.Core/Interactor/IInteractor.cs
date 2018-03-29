using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    /// <summary>
    /// Interactor as described by Robert C. Martin.
    /// </summary>
    /// <typeparam name="TRequest">Request Model. Simple Dto</typeparam>
    /// <typeparam name="TResponse">Response Model. Simple Dto</typeparam>
    public interface IInteractor<in TRequest,TResponse> : IInputBoundary<TRequest> 
        where TRequest : IRequest 
        where TResponse : IResponse
    {
        /// <summary>
        /// Outputboundary. To be implemented on the outter layer. Described as the Presenter by Robert C. Martin.
        /// Used to pass the Response Model to the outter layer.
        /// </summary>
        IOutputBoundary<TResponse> OutputBoundary { get; set; }
    }
}