using MarsRoverAppLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAppLib
{
    public class Planet
    {
        IInputService inputService;
        IOutputService outputService;
        List<ISpaceCar> rovers;
        MapCoordinate coordinate;

        public Planet(IInputService input,IOutputService output)
        {
            inputService = input;
            outputService = output;
        }
        public void CreateMap()
        {
            outputService.WriteMessage("Harita degerini giriniz.");
            string mapCorrdinate = inputService.ReadCommand();
            coordinate = inputService.SetMapCoordinate(mapCorrdinate);
        }
        public void RunRovers()
        {
            foreach (var item in rovers)
            {
                item.SetStartingPosition();
                string movementPlan = item.GetMovementPlan();
                item.Run(coordinate, movementPlan);
                item.SendLastPosition();
            }
        }
        public void GenarateRovers()
        {
            rovers = new List<ISpaceCar>();
            rovers.Add(new Rover("Rover 1", new ConsoleInputService(), new ConsoleOutputService()));
            rovers.Add(new Rover("Rover 2", new ConsoleInputService(), new ConsoleOutputService()));
        }
    }
}
