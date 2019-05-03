﻿using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using ChessApplication.Common.ChessPieces;
using ChessApplication.Common.Enums;
using ChessApplication.Common.UserControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsUtilities;

namespace ChessApplication.Common.UnitTests.ChessPiecesUnitTests.KingUnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class WhiteKingPieceTakingUnitTests
    {
        private Box[,] ChessBoard;

        [TestInitialize]
        public void Setup()
        {
            ChessBoard = ChessboardProvider.GetChessboardFilledWithWhitePawns();
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromNorthWest()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X + 1, whiteKingPosition.Y - 1);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromNorth()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X + 1, whiteKingPosition.Y);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromNorthEast()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X + 1, whiteKingPosition.Y + 1);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromEast()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X, whiteKingPosition.Y + 1);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromSouthEast()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X - 1, whiteKingPosition.Y + 1);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromSouth()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X - 1, whiteKingPosition.Y);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromSouthWest()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X - 1, whiteKingPosition.Y - 1);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCanTakeBlackPieceFromWest()
        {
            var whiteKingPosition = new Point(3, 3);
            var blackPawnPosition = new Point(whiteKingPosition.X, whiteKingPosition.Y - 1);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Piece = new Pawn(PieceColor.Black);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.IsTrue(ChessBoard[blackPawnPosition.X, blackPawnPosition.Y].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }

        [TestMethod]
        public void WhiteKingCantTakeAnyWhitePiece()
        {
            var whiteKingPosition = new Point(3, 3);

            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece = new King(PieceColor.White);
            ChessBoard[whiteKingPosition.X, whiteKingPosition.Y].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(ChessBoard, whiteKingPosition, whiteKingPosition);

            Assert.AreEqual(0, Methods.GetNumberOfAvailableBoxes(ChessBoard));
        }
    }
}