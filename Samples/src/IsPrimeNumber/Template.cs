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
                string inputLine = "";
                int number = 0;

                //ask for number
                Console.Write("Enter a number to check if is a prime number: ");
                inputLine = Console.ReadLine();

                //try to convert
                try
                {
                    number = Int32.Parse(inputLine);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"There was an exception on converting input. Exception: {e.GetBaseException()}");
                    return;
                }

                //run Q# operation to check if number is prime
                var result = IsPrimeNumber.Run(qsim, number).Result;

                if (result == 1)
                {
                    Console.WriteLine($"{number} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{number} isn't a prime number");
                }

            }
        }
    }
}