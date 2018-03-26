using System;
using AppCore;

namespace ConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = new SumTwoNumbersRequest(1, 2);
            var outputBoundary = new SumTwoNumbersOutputBoundary();
            outputBoundary.OnRequestReceived+= Console.WriteLine;

            var usecase = new SumTwoNumbersUseCase(outputBoundary);

            usecase.Execute(request);

            Console.ReadKey();

        }
    }
}
