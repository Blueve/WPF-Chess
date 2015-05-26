using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WPF_Chess.Core;

namespace WPF_Chess_UnitTest
{
    [TestClass]
    public class ChessboardTest
    {
        Chessboard board = new Chessboard();

        [TestMethod]
        public void TestInit()
        {
            board.Init();
            var pieces = board.Pieces;

            Assert.AreEqual(32, pieces.Count);
            Assert.AreEqual("(A, 8)", pieces[0].Position.ToString());
            Assert.AreEqual("(H, 2)", pieces[31].Position.ToString());
        }
    }
}
