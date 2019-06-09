using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAppLib
{
   public class DirectionEngine
    {
        static Dictionary<string, char> spinDirection;
        static DirectionEngine()
        {
            spinDirection = new Dictionary<string, char>();
            spinDirection.Add("NL", 'W');
            spinDirection.Add("NR", 'E');
            spinDirection.Add("NM", 'N');
            spinDirection.Add("SL", 'E');
            spinDirection.Add("SR", 'W');
            spinDirection.Add("SM", 'S');
            spinDirection.Add("EL", 'N');
            spinDirection.Add("ER", 'S');
            spinDirection.Add("EM", 'E');
            spinDirection.Add("WL", 'S');
            spinDirection.Add("WR", 'N');
            spinDirection.Add("WM", 'W');
        }
        public static char GetDirection(string current)
        {
            return spinDirection.First(m => m.Key == current).Value;
        }
        public static int GetStepCount(char head)
        {
            if (head == 'N' || head == 'E')
                return 1;
            else if (head == 'W' || head == 'S')
                return -1;
            else return 0;
        }
        public static char GetAxis(char head)
        {
            if (head == 'N' || head == 'S')
                return 'Y';
            else if (head == 'W' || head == 'E')
                return 'X';
            else return '?';
        }
    }
}
