﻿using System.Diagnostics.CodeAnalysis;
using ChessApplication.Common.ChessPieces;
using ChessApplication.Common.Enums;
using ChessApplication.Common.UserControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessApplication.Common.UnitTests.UserControlsUnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CapturedPieceBoxUnitTests
    {
        private CapturedPieceBox capturedPieceBox;

        [TestMethod]
        public void CapturedPieceBoxBeginsWithCountSetTo0()
        {
            capturedPieceBox = new CapturedPieceBox(new Pawn(PieceColor.White));

            Assert.AreEqual(0, capturedPieceBox.Count);
        }
    }
}
