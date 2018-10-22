using System;
using System.Collections;
using System.Text;

namespace Chess
{
    class ChessHomeWork
    {
        #region Enumerations

        /// <summary>
        /// White and Black Figures Player
        /// </summary>
        public enum Player
        {
            Player1 = 0, // White Figures Player
            Player2 = 1  // Black Figures Player 
        }

        /// <summary>
        /// Chess Board Figures Enumeration 
        /// </summary>
        public enum Figure
        {
            None = 0,   // <empty space>
            Pawn = 1,   // P
            Rook = 2,   // R
            Knight = 3, // N (K is already reserved for King!!!)
            Bishop = 4, // B
            Queen = 5,  // Q
            King = 6,   // K
        }

        /// <summary>
        /// Castling Type - King (Small) and Queen (Big) Castling 
        /// </summary>
        public enum CastlingType
        {
            King, 
            Queen
        }

        #endregion

        #region Structures

        public struct CellAddress
        {
            public char X;
            public byte Y;
        }

        public struct Command
        {
            public char Action;

            public CellAddress From;

            public CellAddress To;

            public CastlingType CastlingType;
        }

        public struct Cell
        {
            public Player Player;
            public Figure Figure;
        }

        #endregion

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Cell[,] board = InitBoard();
            Player currentPlayer = Player.Player1;
            bool isPlayer1Castling = false, isPlayer2Castling = false;

          
            while(true)
            {
                DrawBoard(board);
                WriteGeneralHelp();

                Command command;
                if (!TryGetCommand(currentPlayer, out command))
                    continue;

                switch (command.Action)
                {
                    case 'm':
                        if (!TryMove(currentPlayer, board, command.From, command.To))
                        {
                            // if the move was not valid 
                            // continue with the next iteration 
                            // with the same player
                            continue;
                        }
                            
                        break;

                    case 'u':
                        Undo();
                        break;

                    case 'c':
                       if (currentPlayer == Player.Player1)
                            isPlayer1Castling = Castling(currentPlayer, command.CastlingType, board);
                       else 
                            isPlayer2Castling = Castling(currentPlayer, command.CastlingType, board);
                       break;

                    case 'q':
                        Quit();
                        break;

                    default:
                        Console.WriteLine("Unexpected action!");
                        break;
                }

                if (IsStalemate() || IsCheckmate())
                {
                    Console.WriteLine($"{currentPlayer} won!");
                    break;
                }

                currentPlayer = (currentPlayer == Player.Player1) ? Player.Player2 : Player.Player1;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /// <summary>
        /// Casting (rokada)  - Change Places of Rook and King (Big and Small one) 
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="castlingType"></param>
        /// <param name="board"></param>
        /// <returns></returns>
        private static bool Castling(Player currentPlayer, CastlingType castlingType, Cell[,] board)
        {
            // TODO: implement later
            return true;
        }

        /// <summary>
        /// Verification Is King in Checkmate (shah-mat) position
        /// </summary>
        /// <returns></returns>
        private static bool IsCheckmate()
        {
            // TODO: implement later
            return false;
        }

        /// <summary>
        /// Verification Is King in Stalemate (pat) position 
        /// </summary>
        /// <returns></returns>
        private static bool IsStalemate()
        {
            // TODO: implement later
            return false;
        }

        /// <summary>
        /// End game and quit program 
        /// </summary>
        private static void Quit()
        {
            // closes the application with Error Code 0,
            // which means Success (if not 0, that indicates a problem)
            Environment.Exit(0);
        }

        /// <summary>
        /// Undo last turn
        /// </summary>
        private static void Undo()
        {
            // TODO: implement later
        }

        /// <summary>
        /// Try to move at board position 
        /// </summary>
        /// <param name="currentPlayer"></param>
        /// <param name="board"></param>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        private static bool TryMove(Player currentPlayer, Cell[,] board, 
            CellAddress from, CellAddress to)
        {
            // substracting characters will return a number, because each 
            // character is represented as number / position in Unicode table
            Cell fromCell = board[board.GetLength(0) - from.Y, char.ToLower(from.X) - 'a'];
            Cell toCell = board[board.GetLength(0) - to.Y, char.ToLower(to.X) - 'a'];



            // check if the cell from which we are trying 
            // to move a figure contains any figure             
            if (fromCell.Figure == Figure.None)
            {
                WriteError("Invalid move! No figure at the given position.");
                return false;
            }

            // check if the cell from which we are trying
            // to move contains a figure of the current player
            if (fromCell.Player != currentPlayer)
            {
                WriteError("Invalid move! The figure at the given position is not yours.");
                return false;
            }

            // based on the figure and player (different only for pawns!) move a figure
            // note: no need to use break or default, as we are directly return-ing from the method
            switch (fromCell.Figure)
            {
                case Figure.Pawn:
                    return MovePawn(currentPlayer, board, from, to);
                case Figure.Rook:
                    return MoveRook(currentPlayer, board, from, to);
                case Figure.Bishop:
                    return MoveBishop(currentPlayer, board, from, to);
                case Figure.Knight:
                    return MoveKnight(currentPlayer, board, from, to);
                case Figure.King:
                    return MoveKing(currentPlayer, board, from, to);
                case Figure.Queen:
                    return MoveQueen(currentPlayer, board, from, to);
            }

            return false;
        }

        private static bool MoveQueen(Player currentPlayer, Cell[,] board, CellAddress from, CellAddress to)
        {
            WriteError("Moving the Queen is not implemented.");

            return false;
        }

        private static bool MoveKing(Player currentPlayer, Cell[,] board, CellAddress from, CellAddress to)
        {
            WriteError("Moving the King is not implemented.");

            return false;
        }

        private static bool MoveKnight(Player currentPlayer, Cell[,] board, CellAddress from, CellAddress to)
        {
            WriteError("Moving the Knight is not implemented.");

            return false;
        }

        private static bool MoveBishop(Player currentPlayer, Cell[,] board, CellAddress from, CellAddress to)
        {
            WriteError("Moving the Bishop is not implemented.");

            return false;
        }

        private static bool MoveRook(Player currentPlayer, Cell[,] board, CellAddress from, CellAddress to)
        {
            WriteError("Moving the Rook is not implemented.");

            return false;
        }

        private static bool MovePawn(Player currentPlayer, Cell[,] board, CellAddress from, CellAddress to)
        {
            WriteError("Moving the Pawn is not implemented.");

            return false;
        }

        private static bool TryGetCommand(Player currentPlayer, out Command command)
        {
            Console.Write($"{currentPlayer}:");

            string input = Console.ReadLine().Trim().ToLower();

            // Check if any input is provided 
            if (string.IsNullOrWhiteSpace(input))
            {
                WriteError("Unrecognized command!");
                WriteGeneralHelp();

                command = default(Command);
                return false;
            }

            var cmd = Convert.ToChar(input.Substring(0, 1));

            if (cmd == 'q' && input.Length == 1)
            {
                command = new Command() { Action = cmd };
                return true;
            }

            if (cmd == 'u' && input.Length == 1)
            {
                command = new Command() { Action = cmd };
                return true;
            }

            // Example 'm c7 c6'
            if (cmd == 'm' /* TODO: more condition for homework :) */)
            {
                // TODO: parsing (splitting the string) to be implemented for homework :)

                string[] parameters = input.Substring(1).Trim().Split(' ');

                // Verify for first letter is Character and second Character is a digit 
                if (!(char.IsLetter(parameters[0][0])) || (char.IsDigit(parameters[0][1]))
                 || !(char.IsLetter(parameters[1][0])) || (char.IsDigit(parameters[1][1])))
                {
                    WriteError("Unrecognized command!");
                    WriteError("Expects M XY XY (Example: M A2 A3)");

                    command = new Command();
                    return true;
                }


                // Verify 
                if (!(parameters[0][0] >= 'a' && parameters[0][0] <= 'h') ||
                    !(parameters[1][0] >= 'a' && parameters[1][0] <= 'h'))
                {
                    WriteError("Unrecognized command!");
                    WriteError("Expects M XY XY (Example: M A2 A3)");

                    command = new Command();
                    return true;

                }

                // Verify
                if (!(parameters[0][1] >= 1 && parameters[0][1] <= 8) ||
                    !(parameters[1][1] >= 1 && parameters[1][1] <= 8))
                {
                    WriteError("Unrecognized command!");
                    WriteError("Expects M XY XY (Example: M A2 A3)");

                    command = new Command();
                    return true;

                }

                CellAddress from = new CellAddress() { X = parameters[0][0], Y = byte.Parse(parameters[0][1].ToString()) };
                CellAddress to = new CellAddress() { X = parameters[1][0], Y = byte.Parse(parameters[1][1].ToString()) };

                command = new Command() { Action = cmd, From = from, To = to };
                return true;
            }


            // Example: 'c k' - castling king or 'c q' - castling queen 
            if (cmd == 'c')
            {
                string[] parts = input.Split(' ');

                // Check is there only two letters divided by space 
                if (parts.Length != 2)
                {
                    WriteError("Unrecognized command!");
                    WriteError("Expects [C]astling [K]ing or [C]astling [Q]ueen");
                    command = default(Command);
                    return false;
                }

                // Check that we have two parts, that are 1 letter long
                // and the second part is either 'q' or 'k'
                if (parts[1].Length == 1 && (parts[1][0] == 'q' || parts[1][0] == 'k'))
                {
                    if (parts[1][0] == 'q')
                    {
                        command = new Command() { Action = cmd, CastlingType = CastlingType.Queen };
                        return true;
                    }
                    else if (parts[1][0] == 'k')
                    {
                        command = new Command() { Action = cmd, CastlingType = CastlingType.King };
                        return true;
                    }
                }

                // If we reach this point we don't know hot to handle the command
                WriteError("Unrecognized command!");
                WriteError("Expects [C]astling [K]ing or [C]astling [Q]ueen");
                command = default(Command);
                return false;
            }

            WriteError("Unrecognized command!");
            WriteGeneralHelp();

            command = default(Command);
            return false;
        }

        private static void WriteError(string msg)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = originalColor;
        }

        private static void DrawBoard(Cell[,] board)
        {
            // represents a map / relation between the enumeration 
            // and a one letter presentation when we print it on screen
            Hashtable figureMap = new Hashtable()
            {
                { Figure.None,      ' ' },
                { Figure.Pawn,      'P' },
                { Figure.Rook,      'R' },
                { Figure.Knight,    'N' }, // K is already reserved for King!!!
                { Figure.Bishop,    'B' },
                { Figure.Queen,     'Q' },
                { Figure.King,      'K' }
            };

            Console.WriteLine("    A   B   C   D   E   F   G   H");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // each row has top border
                Console.WriteLine("  +---+---+---+---+---+---+---+---+");

                // reverse row indexes to match real world chess
                Console.Write($"{board.GetLength(0) - i} ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("|");

                    // TODO: Add Change Background Color 

                    var currentForgraund = Console.ForegroundColor;

                    Console.ForegroundColor = (board[i, j].Player == Player.Player1) ? 
                                              ConsoleColor.Green : ConsoleColor.Blue;

                    Console.Write(" {0} ", figureMap[board[i,j].Figure]);

                    Console.ForegroundColor = currentForgraund;

                }

                Console.WriteLine($"| {board.GetLength(1) - i}");
            }

            // footer (bottom line)
            Console.WriteLine("  +---+---+---+---+---+---+---+---+");
            Console.WriteLine("    A   B   C   D   E   F   G   H");
        }

        private static Cell[,] InitBoard()
        {
            var initialBoard = new Cell[8, 8];

            int pawnsRowPlayer1 = 1;
            int pawnsRowPlayer2 = 6;

            // add player 1 figures
            InitPlayerFigures(initialBoard, Player.Player1, pawnsRowPlayer1);

            // add player 2 figures
            InitPlayerFigures(initialBoard, Player.Player2, pawnsRowPlayer2);

            return initialBoard;
        }

        public static void InitPlayerFigures(Cell[,] board, Player player, int pawnRaw)
        {
            int backRaw = (player == Player.Player1) ? (pawnRaw - 1) : (pawnRaw + 1);

            // Add Player Rook
            board[backRaw, 0] = new Cell
            {
                Player = player,
                Figure = Figure.Rook
            };

            // Add Player Knight
            board[backRaw, 1] = new Cell
            {
                Player = player,
                Figure = Figure.Knight
            };

            // Add Player Bishop
            board[backRaw, 2] = new Cell
            {
                Player = player,
                Figure = Figure.Bishop
            };

            // Add Player Queen
            board[backRaw, 3] = new Cell
            {
                Player = player,
                Figure = (player == Player.Player1) ? (Figure.Queen) : (Figure.King)
            };

            // Add Player King
            board[backRaw, 4] = new Cell
            {
                Player = player,
                Figure = (player == Player.Player1) ? (Figure.King) : (Figure.Queen)
            };

            // Add Player Bishop
            board[backRaw, 5] = new Cell
            {
                Player = player,
                Figure = Figure.Bishop
            };

            // Add Player Knight
            board[backRaw, 6] = new Cell
            {
                Player = player,
                Figure = Figure.Knight
            };

            // Add Player Rook
            board[backRaw, 7] = new Cell
            {
                Player = player,
                Figure = Figure.Rook
            };

            // Add Player Pawns
            for (int row = pawnRaw, col = 0; col < board.GetLength(0); col++)
            {
                board[row, col] = new Cell
                {
                    Player = player,
                    Figure = Figure.Pawn
                };
            }
        }

        private static void WriteGeneralHelp()
        {
            WriteError("Expects [M]ove, [U]ndo, [C]astling [K]ing, [C]astling [Q]ueen or [Q]uit");
        }
    }
}
