﻿using System.Drawing;
using ChessApplication.Common.Enums;
using ChessApplication.Common.Interfaces;

namespace ChessApplication.Common.ChessPieces
{
    public class King : ChessPiece
    {
        public King(PieceColor pieceColor)
        {
            Color = pieceColor;
            Image = Color == PieceColor.White ? Properties.Resources.WhiteKing : Properties.Resources.BlackKing;
        }

        public override string Abbreviation
        {
            get
            {
                var abbreviation = string.Empty;
                abbreviation += Abbreviations.King;
                abbreviation += Color == PieceColor.White ? Abbreviations.White : Abbreviations.Black;

                return abbreviation;
            }
        }

        public override void CheckPossibilitiesForProvidedLocationAndMarkThem(IChessboard chessBoard, Point location)
        {
            Point newKingPosition;
            var kingPosition = chessBoard[location].Piece.Color == PieceColor.White
                ? chessBoard.PositionWhiteKing
                : chessBoard.PositionBlackKing;

            newKingPosition = new Point(kingPosition.X + 1, kingPosition.Y - 1);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X + 1, kingPosition.Y + 1);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X + 1, kingPosition.Y);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X, kingPosition.Y - 1);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X, kingPosition.Y + 1);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X - 1, kingPosition.Y - 1);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X - 1, kingPosition.Y);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }

            newKingPosition = new Point(kingPosition.X - 1, kingPosition.Y + 1);
            if (IsMovePossible(chessBoard, kingPosition, newKingPosition))
            {
                chessBoard[newKingPosition].Available = true;
                chessBoard[kingPosition].Piece.CanMove = true;
            }
        }

        private bool IsMovePossible(IChessboard chessBoard, Point source, Point destination)
        {
            if (chessBoard[source] == null || chessBoard[destination] == null)
            {
                return false;
            }

            var isPossible = false;
            var locationKingSource = chessBoard[source];
            var locationKingDestination = chessBoard[destination];
            
            if (locationKingDestination.Piece != null)
            {
                if (locationKingDestination.Piece.Color != locationKingSource.Piece.Color)
                {
                    // Pretend the king was moved to the destination
                    var chessPieceBackup = chessBoard[destination].Piece;
                    chessBoard[destination].Piece = chessBoard[source].Piece;
                    chessBoard[source].Piece = null;

                    if (!IsInCheck(chessBoard, destination))
                    {
                        isPossible = true;
                    }

                    // Restore states of the king and of the destination
                    chessBoard[source].Piece = chessBoard[destination].Piece;
                    chessBoard[destination].Piece = chessPieceBackup;
                }
            }
            else
            {
                // Pretend the king was moved to the destination
                chessBoard[destination].Piece = chessBoard[source].Piece;
                chessBoard[source].Piece = null;

                if (!IsInCheck(chessBoard, destination))
                {
                    isPossible = true;
                }

                // Restore states of the king and of the destination
                chessBoard[source].Piece = chessBoard[destination].Piece;
                chessBoard[destination].Piece = null;
            }

            return isPossible;
        }

        private bool IsInCheck(IChessboard chessBoard, Point location)
        {
            return chessBoard.PieceIsThreatened(location);
        }
    }
}
