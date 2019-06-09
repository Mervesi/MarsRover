using MarsRoverAppLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet planet = new Planet(new ConsoleInputService(), new ConsoleOutputService());
            planet.CreateMap();
            planet.GenarateRovers();
            planet.RunRovers();
        }
    }
}
