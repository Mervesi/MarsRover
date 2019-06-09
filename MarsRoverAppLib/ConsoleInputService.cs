using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRoverAppLib.Model;

namespace MarsRoverAppLib
{
    public class ConsoleInputService : IInputService
    {
        public string GetMovementPlan(string movement)
        {
            return movement;
        }

        public string ReadCommand()
        {
            return Console.ReadLine();
        }

        public MapCoordinate SetMapCoordinate(string mapCoordinate)
        {
            var splitCoordinate = mapCoordinate.Split(' ');
            MapCoordinate mc = new MapCoordinate();
            mc.X = int.Parse(splitCoordinate[0]);
            mc.Y = int.Parse(splitCoordinate[1]);

            return mc;
        }

        public RoverCoordinateStatus SetRoverStartingPosition(string startPosition)
        {
            var splitCoordinate = startPosition.Split(' ');
            RoverCoordinateStatus rc = new RoverCoordinateStatus();
            rc.XPoint = int.Parse(splitCoordinate[0]);
            rc.YPoint = int.Parse(splitCoordinate[1]);
            rc.Head = char.Parse(splitCoordinate[2]);

            return rc;

        }
    }
}
