namespace FD.CleanArchitecture.Core.Boundary
{
    /// <summary>
    /// Input boudary implemented by the interactor
    /// </summary>
    /// <typeparam name="TRequest">Request Model. Simple Dto</typeparam>
    public interface IInputBoundary<in TRequest>
        where TRequest : IRequest 
    {

        /// <summary>
        /// Input Boundary entry point.
        /// Executes the use case.
        /// </summary>
        /// <param name="request"></param>
        void Execute(TRequest request);
    }
}