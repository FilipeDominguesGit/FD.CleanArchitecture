using FD.CleanArchitecture.Core;
using FD.CleanArchitecture.Core.Boundary;

namespace AppCore
{
    public class SumTwoNumbersResponse : IReponse
    {
        public SumTwoNumbersResponse(int total)
        {
            Total = total;
        }

        public int Total { get; }
    }
}