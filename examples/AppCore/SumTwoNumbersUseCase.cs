using System;
using FD.CleanArchitecture.Core;
using FD.CleanArchitecture.Core.Boundary;
using FD.CleanArchitecture.Core.Interactor;

namespace AppCore
{
    public class SumTwoNumbersUseCase : Interactor<SumTwoNumbersRequest, SumTwoNumbersResponse>
    {
        public SumTwoNumbersUseCase(IOutputBoundary<SumTwoNumbersResponse> outputBoundary) : base(outputBoundary) { }

        public override void Execute(SumTwoNumbersRequest request)
        {   
            try
            {
                var response = new SumTwoNumbersResponse(request.NumberA + request.NumberB);
                OutputBoundary.PublishSuccess(response);
            }
            catch (Exception e)
            {
                OutputBoundary.PublishError(e.Message);
            }
        }
    }
}
