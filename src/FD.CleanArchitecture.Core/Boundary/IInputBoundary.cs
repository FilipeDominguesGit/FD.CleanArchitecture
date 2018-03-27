namespace FD.CleanArchitecture.Core.Boundary
{
    public interface IInputBoundary<in TRequest, out TResponse>
        where TRequest : IRequest where TResponse : IReponse
    {
        void Execute(TRequest request,IOutputBoundary<TResponse> outputBounday);
    }
}