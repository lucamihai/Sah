﻿using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using ChessApplication.Common.ChessPieces;
using ChessApplication.Common.Enums;
using ChessApplication.Common.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsUtilities;

namespace ChessApplication.Common.UnitTests.ChessPiecesUnitTests.RookUnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class BlackRookCheckUnitTests
    {
        private IChessboard Chessboard;

        [TestInitialize]
        public void Setup()
        {
            Chessboard = ChessboardProvider.GetChessboardClassicWithNoPieces();
        }

        [TestMethod]
        public void BlackRookCantMoveIfWillCauseCheck()
        {
            var blackKingPosition = new Point(3, 3);
            var blackRookPosition = new Point(4, 4);
            var whiteQueenPosition = new Point(5, 5);

            Chessboard[blackKingPosition].Piece = new King(PieceColor.Black);
            Chessboard[blackRookPosition].Piece = new Rook(PieceColor.Black);
            Chessboard[whiteQueenPosition].Piece = new Queen(PieceColor.White);
            Chessboard.PositionBlackKing = blackKingPosition;

            Chessboard[blackRookPosition].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(Chessboard, blackRookPosition);

            Assert.AreEqual(0, Methods.GetNumberOfAvailableBoxes(Chessboard));
        }

        [TestMethod]
        public void BlackRookCantTakePieceIfWillCauseCheck()
        {
            var blackKingPosition = new Point(3, 3);
            var blackRookPosition = new Point(4, 4);
            var whiteQueenPosition = new Point(5, 5);
            var whitePawnPosition = new Point(4, 5);

            Chessboard[blackKingPosition].Piece = new King(PieceColor.Black);
            Chessboard[blackRookPosition].Piece = new Rook(PieceColor.Black);
            Chessboard[whiteQueenPosition].Piece = new Queen(PieceColor.White);
            Chessboard[whitePawnPosition].Piece = new Pawn(PieceColor.White);
            Chessboard.PositionBlackKing = blackKingPosition;

            Chessboard[blackRookPosition].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(Chessboard, blackRookPosition);

            Assert.IsFalse(Chessboard[whitePawnPosition].Available);
        }

        [TestMethod]
        public void BlackRookCantMoveIfCantPreventCheck()
        {
            var blackKingPosition = new Point(3, 3);
            var blackRookPosition = new Point(3, 2);
            var whiteQueenPosition = new Point(1, 3);

            Chessboard[blackKingPosition].Piece = new King(PieceColor.Black);
            Chessboard[blackRookPosition].Piece = new Rook(PieceColor.Black);
            Chessboard[whiteQueenPosition].Piece = new Queen(PieceColor.White);
            Chessboard.PositionBlackKing = blackKingPosition;

            Chessboard[blackRookPosition].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(Chessboard, blackRookPosition);

            Assert.AreEqual(0, Methods.GetNumberOfAvailableBoxes(Chessboard));
        }

        [TestMethod]
        public void BlackRookCantTakePieceIfCantPreventCheck()
        {
            var blackKingPosition = new Point(3, 3);
            var blackRookPosition = new Point(8, 8);
            var whitePawnPosition = new Point(7, 8);
            var whiteQueenPosition = new Point(1, 3);

            Chessboard[blackKingPosition].Piece = new King(PieceColor.Black);
            Chessboard[blackRookPosition].Piece = new Rook(PieceColor.Black);
            Chessboard[whitePawnPosition].Piece = new Pawn(PieceColor.White);
            Chessboard[whiteQueenPosition].Piece = new Queen(PieceColor.White);
            Chessboard.PositionBlackKing = blackKingPosition;

            Chessboard[blackRookPosition].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(Chessboard, blackRookPosition);

            Assert.AreEqual(0, Methods.GetNumberOfAvailableBoxes(Chessboard));
        }

        [TestMethod]
        public void BlackRookCanMoveIfCanPreventCheck()
        {
            var blackKingPosition = new Point(3, 3);
            var blackRookPosition = new Point(1, 7);
            var whiteQueenPosition = new Point(3, 8);

            Chessboard[blackKingPosition].Piece = new King(PieceColor.Black);
            Chessboard[blackRookPosition].Piece = new Rook(PieceColor.Black);
            Chessboard[whiteQueenPosition].Piece = new Queen(PieceColor.White);
            Chessboard.PositionBlackKing = blackKingPosition;

            Chessboard[blackRookPosition].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(Chessboard, blackRookPosition);

            var defensePosition = new Point(whiteQueenPosition.X, blackRookPosition.Y);
            Assert.IsTrue(Chessboard[defensePosition].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(Chessboard));
        }

        [TestMethod]
        public void WhiteRookCanTakePieceIfCanPreventCheck()
        {
            var blackKingPosition = new Point(3, 3);
            var blackRookPosition = new Point(1, 2);
            var whiteQueenPosition = new Point(1, 3);

            Chessboard[blackKingPosition].Piece = new King(PieceColor.Black);
            Chessboard[blackRookPosition].Piece = new Rook(PieceColor.Black);
            Chessboard[whiteQueenPosition].Piece = new Queen(PieceColor.White);
            Chessboard.PositionBlackKing = blackKingPosition;

            Chessboard[blackRookPosition].Piece
                .CheckPossibilitiesForProvidedLocationAndMarkThem(Chessboard, blackRookPosition);

            Assert.IsTrue(Chessboard[whiteQueenPosition].Available);
            Assert.AreEqual(1, Methods.GetNumberOfAvailableBoxes(Chessboard));
        }
    }
}