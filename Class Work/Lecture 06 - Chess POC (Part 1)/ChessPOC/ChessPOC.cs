using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessPOC
{
    class ChessPOC
    {
        #region Enumerations 

        public enum Figures
        {
            None = 0,   // empty space
            Pawn = 1,   // P
            Rook = 2,   // R
            Knight = 3, // N
            Bishop = 4, // B
            Queen = 5,  // Q
            King = 6    // K
        }

        public enum Player
        {
            Player1 = 0,
            Player2 = 1
        }

        public enum CastlingType
        {
            King = 0,
            Queen = 1
        }

        #endregion

        #region Structures 

        public struct CellAddress
        {
            public char x;
            public int y; 
        }


        public struct Command
        {
            public char Action;

            public CellAddress From;

            public CellAddress To;

            public CastlingType CastlingType;
        }

        #endregion

        static void Main(string[] args)
        {
            Figures[,] board = InitBoard();

            Player currentPlayer = Player.Player1;

            bool isPlayer1Castling = false;

            bool isPlayer2Castling = false;

            while (true)
            {
                DrawBoard(board);

                Command command = NextCommand();

                if (!IsValidActions(command))
                {
                    continue;
                }

                switch (command.Action)
                {
                    case 'm': // "move"
                        Move();
                        break;
                    case 'u': // "undo"
                        Undo();
                        break;
                    case 'c': // "queen-castling" and "king-castling"
                        if (currentPlayer == Player.Player1)
                            isPlayer1Castling = Castling(currentPlayer, command.CastlingType, board); 
                        else
                            isPlayer2Castling = Castling(currentPlayer, command.CastlingType, board); 
                        break;
                    case 'q': // "quit"
                        Quit();
                        break;
                    default: 
                        Console.WriteLine("Unexpected action! Try again!");
                        break;
                }


                if (IsCheckMate() || IsStalemate())
                {
                    Console.WriteLine($"{currentPlayer} won");
                }

                currentPlayer = currentPlayer == Player.Player1 ? Player.Player2 : Player.Player1;

               
            };

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }

        private static bool IsValidActions(Command command)
        {
            throw new NotImplementedException();
        }

        private static bool Castling(Player currentPlayer, CastlingType castlingType, Figures[,] board)
        {
            return true;
        }

        #region Methods
        private static Command NextCommand()
        {
            throw new NotImplementedException();
        }

        private static bool IsValidActions(Player currentPlayer, Command command)
        {
            Console.WriteLine($"{currentPlayer}: ");
            // m XY XY
            // u
            // q
            // c q||k [XY]

            string input = Console.ReadLine().Trim();

            //if (input.Substring(0, 1)) ; // Take only first letter 
            //{

            //}

            return true;
        }

        private static bool IsStalemate()
        {
            throw new NotImplementedException();
        }

        private static bool IsCheckMate()
        {
            throw new NotImplementedException();
        }

        private static void Quit()
        {
            Environment.Exit(0);
        }

        private static void KingCastling()
        {
            throw new NotImplementedException();
        }


        private static void Undo()
        {
            throw new NotImplementedException();
        }

        private static void Move()
        {
            throw new NotImplementedException();
        }

        private static Figures[,] InitBoard()
        {
            var initialBoard = new Figures[8, 8];

            // Add Player 1 Figures

            // Add Player 2 Figures

            return initialBoard; 
        }

        public static void DrawBoard(Figures[,] board)
        {

        }
        #endregion
    }

}
