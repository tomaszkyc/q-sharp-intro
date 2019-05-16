using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication4
{
    class Template
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {

                //array with values
                long[] arr = new long[] { 1, 2, 3, 4, 5 };



                //number to search in array
                int searchedNumber = 6;

                var result = IsNumberInArr.Run(qsim, new QArray<long>(arr), searchedNumber).Result;

                //show result
                Console.WriteLine($"Is number: {searchedNumber} found: {result}");

                
            }
        }
    }
}