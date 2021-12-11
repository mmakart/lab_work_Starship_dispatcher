using System;
using System.IO;
using System.Collections.Generic;
using StarshipDispatcher;

namespace ConsoleStarshipDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file name for input data: ");
            var inputFilename = Console.ReadLine();

            Console.Write("Enter file name for output data: ");
            var outputFilename = Console.ReadLine();

            try
            {
                var initialData = Parser.Parse(inputFilename);
                var schedule = Dispatcher.CompileSchedule(initialData) as List<Departure>;

                Reporter.Send(schedule, outputFilename);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
