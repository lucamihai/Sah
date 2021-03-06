﻿using System.Drawing;
using ChessApplication.Common.Enums;
using ChessApplication.Common.Interfaces;

namespace ChessApplication.Common.ChessPieces
{
    public class Knight : ChessPiece
    {
        public Knight(PieceColor pieceColor)
        {
            Color = pieceColor;
            Image = pieceColor == PieceColor.White ? Properties.Resources.WhiteKnight : Properties.Resources.BlackKnight;
        }

        public override string Abbreviation
        {
            get
            {
                var abbreviation = string.Empty;
                abbreviation += Abbreviations.Knight;
                abbreviation += Color == PieceColor.White ? Abbreviations.White : Abbreviations.Black;

                return abbreviation;
            }
        }

        public override void CheckPossibilitiesForProvidedLocationAndMarkThem(IChessboard chessBoard, Point location)
        {
            var row = location.X;
            var column = location.Y;

            int destinationRow, destinationColumn;
            Point destination;

            if (row < 8 && column < 7)
            {
                destinationRow = row + 1;
                destinationColumn = column + 2;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row < 8 && column > 2) 
            {
                destinationRow = row + 1;
                destinationColumn = column - 2;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row < 7 && column < 8) 
            {
                destinationRow = row + 2;
                destinationColumn = column + 1;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row < 7 && column > 1) 
            {
                destinationRow = row + 2;
                destinationColumn = column - 1;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row > 1 && column < 7) 
            {
                destinationRow = row - 1;
                destinationColumn = column + 2;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row > 1 && column > 2) 
            {
                destinationRow = row - 1;
                destinationColumn = column - 2;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row > 2 && column < 8) 
            {
                destinationRow = row - 2;
                destinationColumn = column + 1;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }

            if (row > 2 && column > 1) 
            {
                destinationRow = row - 2;
                destinationColumn = column - 1;
                destination = new Point(destinationRow, destinationColumn);

                if (chessBoard[destinationRow, destinationColumn].Piece != null)
                {
                    if (chessBoard[destinationRow, destinationColumn].Piece.Color != chessBoard[row, column].Piece.Color)
                    {
                        if (!chessBoard.MoveTriggersCheck(location, destination))
                        {
                            chessBoard[destinationRow, destinationColumn].Available = true;
                            chessBoard[row, column].Piece.CanMove = true;
                        }
                    }
                }
                else
                {
                    if (!chessBoard.MoveTriggersCheck(location, destination))
                    {
                        chessBoard[destinationRow, destinationColumn].Available = true;
                        chessBoard[row, column].Piece.CanMove = true;
                    }
                }
            }
        }
    }
}
