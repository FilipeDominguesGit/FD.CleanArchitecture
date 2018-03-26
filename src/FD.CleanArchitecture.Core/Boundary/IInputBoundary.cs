namespace FD.CleanArchitecture.Core.Boundary
{
    public interface IInputBoundary<in TRequest>
        where TRequest : IRequest
    {
        void Execute(TRequest request);
    }
}