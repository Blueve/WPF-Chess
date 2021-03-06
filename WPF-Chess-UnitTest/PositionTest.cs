﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WPF_Chess.Common;

namespace WPF_Chess_UnitTest
{
    [TestClass]
    public class PositionTest
    {
        [TestMethod]
        public void TestCtor()
        {
            Position e = new Position { X = 1, Y = 5 };

            Position a = new Position(1, 5);
            Assert.AreEqual(e, a);

            a = new Position('B', 3);
            Assert.AreEqual(e, a);
        }

        [TestMethod]
        public void TestEqualityComparer()
        {
            Position e = new Position { X = 1, Y = 5 };
            Position a = new Position(1, 5);

            Assert.IsTrue(e.Equals(a));
            Assert.IsTrue(e.GetHashCode() == 15);
            Assert.IsTrue(e.GetHashCode() == a.GetHashCode());

            a.X = 2;
            Assert.IsFalse(e.Equals(a));
            Assert.IsTrue(a.GetHashCode() == 25);
            Assert.IsFalse(e.GetHashCode() == a.GetHashCode());

            a = e;
            Assert.IsTrue(e.GetHashCode() == a.GetHashCode());
        }

        [TestMethod]
        public void TestSetter()
        {
            Position e = new Position { X = -1, Y = -1 };

            Assert.AreEqual(e, new Position(100, -100));
            Assert.AreEqual(e, new Position(8, 8));
            Assert.AreEqual(e, new Position(-1, -1));

            e = new Position { X = 1, Y = 5 };
            Position a = new Position();

            a.X = 1;
            a.Y = 5;
            Assert.AreEqual(e, a);
        }

        [TestMethod]
        public void TestGetter()
        {
            Position e = new Position { X = 2, Y = 4 };

            Assert.AreEqual(2, e.X);
            Assert.AreEqual(4, e.Y);
        }

        [TestMethod]
        public void TestToString()
        {
            Position e = new Position { X = 1, Y = 5 };
            Assert.AreEqual("(B, 3)", e.ToString());

            e = new Position('B', 6);
            Assert.AreEqual("(B, 6)", e.ToString());
        }
    }
}
