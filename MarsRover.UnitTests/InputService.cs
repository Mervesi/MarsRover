using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRoverAppLib;

namespace MarsRover.UnitTests
{
    /// <summary>
    /// Summary description for InputService
    /// </summary>
    [TestClass]
    public class InputService
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetMovementPlan_MovementIsNullOrEmpty()
        {
            ConsoleInputService cs = new ConsoleInputService();
            cs.GetMovementPlan("");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMovementPlan_MovementIncludeInt()
        {
            ConsoleInputService cs = new ConsoleInputService();
            cs.GetMovementPlan("1M3");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetMovementPlan_MovementIncludeExcept_RLM()
        {
            ConsoleInputService cs = new ConsoleInputService();
            cs.GetMovementPlan("KLM");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetMapCoordinate_MapCoordinateIsNullOrEmpty()
        {
            ConsoleInputService cs = new ConsoleInputService();
            cs.SetMapCoordinate("");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetMapCoordinate_MapCoordinateIncludeLetter()
        {
            ConsoleInputService cs = new ConsoleInputService();
            cs.SetMapCoordinate("adfgn");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetRoverStartingPosition_StartPositionIsNullOrEmpty()
        {
            ConsoleInputService cs = new ConsoleInputService();
            cs.SetRoverStartingPosition("");
        }
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void SetRoverStartingPosition_StartPositionLessThenTwoCoordinate()
        //{
        //    ConsoleInputService cs = new ConsoleInputService();
        //    cs.SetRoverStartingPosition("1");
        //}


    }
}
