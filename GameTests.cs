using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic1.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void StartGameTest()
        {
            Game game = new Game(4);
            game.StartGame();
            Assert.AreEqual(1, game.GetDigitAt(0, 0));
            Assert.AreEqual(2, game.GetDigitAt(1, 0));
            Assert.AreEqual(5, game.GetDigitAt(0, 1));
            Assert.AreEqual(15, game.GetDigitAt(2, 3));
            Assert.AreEqual(0, game.GetDigitAt(3, 3));
        }

        [TestMethod()]
        public void PressButtonTest()
        {
            Game game = new Game(4);
            game.StartGame();
            game.PressButton(2, 3);
            Assert.AreEqual(0, game.GetDigitAt(2, 3));
            Assert.AreEqual(15, game.GetDigitAt(3, 3));
            game.PressButton(2, 2);
            Assert.AreEqual(0, game.GetDigitAt(2, 2));
            Assert.AreEqual(11, game.GetDigitAt(2, 3));

        }

        [TestMethod()]
        public void GetDigitAtTest()
        {
            Game game = new Game(4);
            game.StartGame();
            Assert.AreEqual(0, game.GetDigitAt(-10, -9765));
            Assert.AreEqual(0, game.GetDigitAt(78, 253));

        }

        [TestMethod()]
        public void SolvedTest()
        {
            Game game = new Game(4);
            game.StartGame();
            Assert.IsTrue(game.Solved());
            game.PressButton(2, 3);
            Assert.IsFalse(game.Solved());
            game.PressButton(3, 3);
            Assert.IsTrue(game.Solved());
        }
    }
}