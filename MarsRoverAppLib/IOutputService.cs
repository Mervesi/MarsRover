using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverAppLib
{
   public interface IOutputService
    {
        void WriteMessage(string message);
    }
}
