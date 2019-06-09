﻿using MarsRoverAppLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAppLib
{
    public class Rover : ISpaceCar
    {
        public string Name { get; }
        IInputService inputService;
        IOutputService outputService;
        RoverCoordinateStatus roverStatus;
        public Rover()
        {
        }
        public Rover(string name, IInputService input, IOutputService output)
        {
            Name = name;

            inputService = input;
            outputService = output;
        }

        

        public string GetMovementPlan()
        {
            outputService.WriteMessage($"{this.Name} hareket planını giriniz.");
            string komut = inputService.ReadCommand();
            return inputService.GetMovementPlan(komut);
        }

        public void Run(MapCoordinate coordinate, string movement)
        {
            foreach (var item in movement)
            {
                if (item=='M')
                {
                    var stepCount = DirectionEngine.GetStepCount(item);
                    if (DirectionEngine.GetAxis(item)=='Y')
                    {
                        roverStatus.YPoint = roverStatus.YPoint + stepCount;
                    }
                    else if (DirectionEngine.GetAxis(item)=='X')
                    {
                        roverStatus.XPoint = roverStatus.XPoint + stepCount;
                    } 
                }
                roverStatus.Head = DirectionEngine.GetDirection(item.ToString());
            }
        }

        public void SendLastPosition()
        {
            outputService.WriteMessage($"{this.Name} aracının son pozisyonu {roverStatus.XPoint} {roverStatus.YPoint} {roverStatus.Head}");
        }

        public void SetStartingPosition()
        {
            outputService.WriteMessage($"{this.Name} Başlangıç degerini giriniz.");
            string komut = inputService.ReadCommand();
            roverStatus = inputService.SetRoverStartingPosition(komut);
        }
    }
    public interface ISpaceCar
    {
        string Name { get; }
        void Run(MapCoordinate coordinate, string movement);
        void SendLastPosition();
        string GetMovementPlan();
        void SetStartingPosition();
    }
}
