using FD.CleanArchitecture.Core.Boundary;

namespace FD.CleanArchitecture.Core.Interactor
{
    public abstract class Interactor<TRequest,TResponse> : IInteractor<TRequest, TResponse> where TRequest : IRequest 
        where TResponse : IReponse
    {
        public IOutputBoundary<TResponse> OutputBoundary { get; }

        protected Interactor(IOutputBoundary<TResponse> outputBoundary)
        {
            this.OutputBoundary = outputBoundary;
        }

        public abstract void Execute(TRequest request);
    }
}
