﻿using System.Diagnostics.CodeAnalysis;
using ChessApplication.Common.ChessPieces;
using ChessApplication.Common.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChessApplication.Common.UnitTests
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ChessboardUnitTests
    {
        private Chessboard chessboard;

        [TestInitialize]
        public void Setup()
        {
            chessboard = new Chessboard();
        }

        [TestMethod]
        public void WhitePiecesAreAdded()
        {
            var whitePawnsAreAdded = WhitePawnsAreAdded();
            var whiteRooksAreAdded =
                chessboard[1, 1].Piece is Rook && chessboard[1, 1].Piece.Color == PieceColor.White
                && chessboard[1, 8].Piece is Rook && chessboard[1, 8].Piece.Color == PieceColor.White;

            var whiteKnightsAreAdded =
                chessboard[1, 2].Piece is Knight && chessboard[1, 2].Piece.Color == PieceColor.White
                && chessboard[1, 7].Piece is Knight && chessboard[1, 7].Piece.Color == PieceColor.White;

            var whiteBishopsAreAdded =
                chessboard[1, 3].Piece is Bishop && chessboard[1, 3].Piece.Color == PieceColor.White
                && chessboard[1, 6].Piece is Bishop && chessboard[1, 6].Piece.Color == PieceColor.White;

            var whiteQueenIsAdded = chessboard[1, 4].Piece is Queen && chessboard[1, 4].Piece.Color == PieceColor.White;
            var whiteKingIsAdded = chessboard[1, 5].Piece is King && chessboard[1, 5].Piece.Color == PieceColor.White;

            Assert.IsTrue(whitePawnsAreAdded);
            Assert.IsTrue(whiteRooksAreAdded);
            Assert.IsTrue(whiteKnightsAreAdded);
            Assert.IsTrue(whiteBishopsAreAdded);
            Assert.IsTrue(whiteKingIsAdded);
            Assert.IsTrue(whiteQueenIsAdded);
        }

        [TestMethod]
        public void BlackPiecesAreAdded()
        {
            var blackPawnsAreAdded = BlackPawnsAreAdded();
            var blackRooksAreAdded =
                chessboard[8, 1].Piece is Rook && chessboard[8, 1].Piece.Color == PieceColor.Black
                && chessboard[8, 8].Piece is Rook && chessboard[8, 8].Piece.Color == PieceColor.Black;

            var blackKnightsAreAdded =
                chessboard[8, 2].Piece is Knight && chessboard[8, 2].Piece.Color == PieceColor.Black
                && chessboard[8, 7].Piece is Knight && chessboard[8, 7].Piece.Color == PieceColor.Black;

            var blackBishopsAreAdded =
                chessboard[8, 3].Piece is Bishop && chessboard[8, 3].Piece.Color == PieceColor.Black
                && chessboard[8, 6].Piece is Bishop && chessboard[8, 6].Piece.Color == PieceColor.Black;

            var blackQueenIsAdded = chessboard[8, 5].Piece is Queen && chessboard[8, 5].Piece.Color == PieceColor.Black;
            var blackKingIsAdded = chessboard[8, 4].Piece is King && chessboard[8, 4].Piece.Color == PieceColor.Black;

            Assert.IsTrue(blackPawnsAreAdded);
            Assert.IsTrue(blackRooksAreAdded);
            Assert.IsTrue(blackKnightsAreAdded);
            Assert.IsTrue(blackBishopsAreAdded);
            Assert.IsTrue(blackKingIsAdded);
            Assert.IsTrue(blackQueenIsAdded);
        }

        [TestMethod]
        public void BoxesThatShouldNotHaveAPieceDoNotHaveAPiece()
        {
            for (int row = 3; row <= 6; row++)
            {
                for (int column = 1; column < 9; column++)
                {
                    Assert.IsTrue(chessboard[row, column].Piece == null);
                }
            }
        }

        private bool WhitePawnsAreAdded()
        {
            for (int column = 1; column < 9; column++)
            {
                var currentPiece = chessboard[2, column].Piece;

                if (!(currentPiece is Pawn) && currentPiece.Color != PieceColor.White)
                {
                    return false;
                }
            }

            return true;
        }

        private bool BlackPawnsAreAdded()
        {
            for (int column = 1; column < 9; column++)
            {
                var currentPiece = chessboard[7, column].Piece;

                if (!(currentPiece is Pawn) && currentPiece.Color != PieceColor.Black)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
