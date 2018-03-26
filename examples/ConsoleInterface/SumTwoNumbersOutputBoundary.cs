using AppCore;
using FD.CleanArchitecture.Core;
using FD.CleanArchitecture.Core.Boundary;

namespace ConsoleInterface
{
    public class SumTwoNumbersOutputBoundary : IOutputBoundary<SumTwoNumbersResponse>
    {
        public delegate void OnResponseReceived(int total);
        public event OnResponseReceived OnRequestReceived;

        public delegate void OnError(string error);
        public event OnError OnErrorReceived;

        public void PublishSuccess(SumTwoNumbersResponse response)
        {
            OnRequestReceived?.Invoke(response.Total);
        }

        public void PublishError(string error)
        {
            OnErrorReceived?.Invoke(error);
        }
    }
}