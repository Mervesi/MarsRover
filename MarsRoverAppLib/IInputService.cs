using MarsRoverAppLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAppLib
{
    public interface IInputService
    {
        string GetMovementPlan(string movement);
        MapCoordinate SetMapCoordinate(string mapCoordinate);
        RoverCoordinateStatus SetRoverStartingPosition(string startPosition);
        string ReadCommand();
    }
}
