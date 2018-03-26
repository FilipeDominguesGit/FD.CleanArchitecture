using AppApi.ViewModel;
using AppCore;
using FD.CleanArchitecture.Core;
using FD.CleanArchitecture.Core.Boundary;

namespace AppApi.OutputBoundaries
{
    public class SumTwoNumbersOutputBoundary : IOutputBoundary<SumTwoNumbersResponse>
    {
        public SumResultViewModel Response { get; set; }

        public string ErrorMessage { get; set; }

        public bool Success => string.IsNullOrWhiteSpace(ErrorMessage);


        public void PublishSuccess(SumTwoNumbersResponse response)
        {
            Response = new SumResultViewModel(response.Total.ToString());
        }

        public void PublishError(string error)
        {
            ErrorMessage = error;
        }
    }
}