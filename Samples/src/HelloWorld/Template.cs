using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpApplication
{
    class Template
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                //run Hello World and wait for finish
                HelloWorld.Run(qsim).Wait();
            }
        }
    }
}