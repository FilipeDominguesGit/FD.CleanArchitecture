namespace FD.CleanArchitecture.Core.Boundary
{
    /// <summary>
    /// Output boundary. To be implemented on the outter layer.
    /// Transforms the Response Model to the format that fits best to the outter layer.
    /// </summary>
    /// <typeparam name="TResponse">Response Model</typeparam>
    public interface IOutputBoundary<in TResponse> where TResponse : IResponse
    {
        void PublishSuccess(TResponse response);

        void PublishError(string error);
    }
}