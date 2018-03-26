namespace FD.CleanArchitecture.Core.Boundary
{
    public interface IOutputBoundary<in T> where T : IReponse
    {
        void PublishSuccess(T response);

        void PublishError(string error);
    }
}