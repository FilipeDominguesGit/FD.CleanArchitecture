using FD.CleanArchitecture.Core;
using FD.CleanArchitecture.Core.Boundary;

namespace AppCore
{
    public class SumTwoNumbersRequest : IRequest
    {
        public int NumberA { get; }
        public int NumberB { get; }

        public SumTwoNumbersRequest(int numberA, int numberB)
        {
            NumberA = numberA;
            NumberB = numberB;
        }
    }
}