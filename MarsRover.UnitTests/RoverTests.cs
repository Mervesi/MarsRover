using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverAppLib;
using MarsRoverAppLib.Model;

namespace MarsRover.UnitTests
{
   
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Run_MapCoordinateIsNull_Throw()
        {
            Rover rv = new Rover();
            rv.Run(null, "LLM");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Run_MovementIsNullorEmpty_Throw()
        {
            Rover rv = new Rover();
            rv.Run(new MapCoordinate(), "");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_NameIsNullorEmpty()
        {
            Rover rv = new Rover(string.Empty, null, null);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_InputIsNull()
        {
            Rover rv = new Rover("Rover 1", null, new ConsoleOutputService());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Ctor_OutputIsNull()
        {
            Rover rv = new Rover("Rover 1", new ConsoleInputService(), null);
        }
    }
}
