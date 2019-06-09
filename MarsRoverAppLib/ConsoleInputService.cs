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
            if (string.IsNullOrEmpty(movement))
                throw new ArgumentNullException("Hareket Degerini Giriniz!");
            
            foreach (var item in movement)
            {
                if (int.TryParse(item.ToString(), out int a))
                    throw new ArgumentException("Girilen Değer Sayı İçeremez.");

                if (!(item == 'L' || item == 'R' || item == 'M'))
                    throw new ArgumentException("L,R,M haricinde hareket değeri girilmez!!!");
                
            }

            return movement;
        }

        public string ReadCommand()
        {
            return Console.ReadLine();
        }

        public MapCoordinate SetMapCoordinate(string mapCoordinate)
        {
            if (string.IsNullOrEmpty(mapCoordinate))
                throw new ArgumentNullException("Harita Degerini Giriniz!");

            string[] deger = mapCoordinate.Split(' ');
            foreach (var item in deger)
            {
                if (!int.TryParse(item, out int a))
                    throw new ArgumentException("Girilen Değer Harf Olamaz.");
            }

            var splitCoordinate = mapCoordinate.Split(' ');
            MapCoordinate mc = new MapCoordinate();
            mc.X = int.Parse(splitCoordinate[0]);
            mc.Y = int.Parse(splitCoordinate[1]);

            return mc;
        }

        public RoverCoordinateStatus SetRoverStartingPosition(string startPosition)
        {
            if (string.IsNullOrEmpty(startPosition))
                throw new ArgumentNullException("Rover Başlangıc Degerini Giriniz!");

            //if (startPosition.Length!=3)
            //    throw new ArgumentException("Girdiğiniz Başlangıc Degerını Kontrol Ediniz!");


            var splitCoordinate = startPosition.Split(' ');
            RoverCoordinateStatus rc = new RoverCoordinateStatus();
            rc.XPoint = int.Parse(splitCoordinate[0]);
            rc.YPoint = int.Parse(splitCoordinate[1]);
            rc.Head = char.Parse(splitCoordinate[2]);

            return rc;

        }
    }
}
