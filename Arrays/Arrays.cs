using System;

namespace Arrays
{
    public struct AddressInfo
    {
        public string[] Address;
        public string City;
    }

    public enum ChessFigure
    {
        None = 0,
        Pawn = 10,
        Queen = 20,
        King = 30
    }

    class Arrays
    {
        static void Main(string[] args)
        {
            //AddressInfo addressInfo = new AddressInfo()
            //{
            //    Address = new string[] { "Mladost-2 77", "SMG Bulgaria" },
            //    City = "Sofia"
            //};

            //for (int row = 0; row <= addressInfo.Address.Length; row++)
            //{
            //    System.Console.WriteLine(addressInfo.Address[row]);
            //}

            //foreach (string line in addressInfo.Address)
            //{
            //    Console.WriteLine(line);
            //}

            //int x = 0;
            //while (x < addressInfo.Address.Length)
            //{
            //    Console.WriteLine(addressInfo.Address[x++]);
            //}

            //int y = 0;
            //do
            //{
            //    if (addressInfo.Address.Length == 0)
            //    {
            //        break;
            //    }

            //    Console.WriteLine(addressInfo.Address[y++]);

            //} while (y < addressInfo.Address.Length);

            // Create Array
            ChessFigure[,] chessBoard = new ChessFigure[8,8];

            // Initialize Array Values
            for (int row = 1, col = 0; col < chessBoard.GetLength(1); col++)
            {
                chessBoard[row, col] = ChessFigure.Pawn;
            }

            chessBoard[0, 3] = ChessFigure.Queen;
            chessBoard[0, 4] = ChessFigure.King;

            // Print Array Values
            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    if (chessBoard[row, col] == ChessFigure.None)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write($"{chessBoard[row, col].ToString().Substring(0, 1)} ");
                    }

                    Console.WriteLine();
                    
                }
            }


            int[] array = new int[10];

            int[] clonedArray = (int[])array.Clone();

            foreach (var element in clonedArray)
            {
                Console.WriteLine(element);
            }


            string[][] chart = new string[100][];

            chart[0] = new string[] { "Levski" };
            chart[1] = new string[] { "Ludogoretz", "Beroe" };

            for (int position = 0; position < chart.Length; position++)
            {
                if (chart[position].Length == 0)
                {
                    continue;
                }

                Console.Write($"{position + 1}. ");

                //foreach(var team in chart[position])
                //{
                //    Console.WriteLine();
                //}

                Console.WriteLine(string.Join(", ", chart[position]));

            }


            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
