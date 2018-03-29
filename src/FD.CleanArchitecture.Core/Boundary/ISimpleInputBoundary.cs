namespace FD.CleanArchitecture.Core.Boundary
{

    /// <summary>
    /// Simple Input boudary to be implemented by the interactor.
    /// To be unsed only on a simple interactor that has no Output Boundary.
    /// </summary>
    /// <typeparam name="TRequest">Request Model. Simple Dto.</typeparam>
    /// <typeparam name="TResponse">Response Model. Simple Dto</typeparam>
    public interface ISimpleInputBoundary<in TRequest, out TResponse> 
        where TRequest :IRequest
    where TResponse: IResponse
    {
        /// <summary>
        /// Input boundary entry point.
        /// Executes the Use Case
        /// </summary>
        /// <param name="request">Request model.</param>
        /// <returns>Response Model</returns>
        TResponse Execute(TRequest request);

    }
}