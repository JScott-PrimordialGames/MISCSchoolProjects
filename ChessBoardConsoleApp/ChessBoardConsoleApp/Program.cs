using ChessBoardModel;
using System;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);

        static void Main(string[] args)
        {
            // show the empty chess board
            printGrid(myBoard);

            // get the location of the ches piece
            Cell myLocation = setCurrentCell();

            // calculate and mark the cells where lefal moves are possible
            myBoard.MarkNextLeagleMoves(myLocation, "Queen");

            // show the chess board. Use . for an empty square, X for the piece location and + for possivle lecal move 
            printGrid(myBoard);

            // wait for another return key to end the program
            Console.ReadLine();

        }

        static public void printGrid(Board myBoard)
        {

            for(int i = 0; i < myBoard.Size; i++)
            {
                Console.WriteLine("+---+---+---+---+---+---+---+---+");
                Console.Write("| ");
                for(int j = 0; j < myBoard.Size; j++)
                {
                    if(myBoard.theGrid[i,j].CurrentlyOccupied)
                    {
                        Console.Write("X | ");
                    }
                    else if (myBoard.theGrid[i,j].LeagalNextMove)
                    {
                        Console.Write("+ | ");
                    }
                    else
                    {
                        Console.Write(". | ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("==================================");
        }

        static public Cell setCurrentCell()
        {
            int currentRow = 0;
            Console.WriteLine("Enter your current row number ");
            if (int.TryParse(Console.ReadLine(), out int input) && input <= 8)
            {
                currentRow = (input - 1);
            }
            else
            {
                Console.WriteLine("Please ender a single digit between 1 & 8");
            }

            int currentCol = 0;
            Console.WriteLine("Enter your current Column number ");
            if (int.TryParse(Console.ReadLine(), out int input2) && input2 <= 8)
            {
                currentCol = (input2 - 1);
            }
            else
            {
                Console.WriteLine("Please ender a single digit between 1 & 8");
            }

            myBoard.theGrid[currentRow, currentCol].CurrentlyOccupied = true;

            return myBoard.theGrid[currentRow, currentCol];

        }
    }
}
