using System;
using System.Data;

namespace MilestoneProject
{
    class Program
    {

        static Board LiveBoard;

        static void Main(string[] args)
        {
            Console.Out.WriteLine("Making Board");
            int size = 0;

            Console.WriteLine("Please enter a Board Seiz: ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                size = input;
            }
            else
            {
                Console.WriteLine("Please enter a Board Seiz: ");
            }
            LiveBoard = new Board(size);
            LiveBoard.InitializeBoard();
            LiveBoard.PlantBombs();
            LiveBoard.CalculatePlantedBombs();


            Console.Out.WriteLine("Printing Board");
            PrintBoard();

            PlayGame();

        }

        public static void PrintBoard()
        {
            for (int x = 1; x <= LiveBoard.BoardSize; x++)
            {

                Console.Out.Write("*");
                for (int y = 1; y <= LiveBoard.BoardSize; y++)
                {
                    Cell currentCell = LiveBoard.GameBoard.Find(cell => cell.Column == x && cell.Row == y);
                    if (currentCell.Visited)
                    {
                        if(currentCell.LiveNeighbors == 0 | currentCell.LiveNeighbors == 10)
                            Console.Out.Write("| ~ ");
                        else
                            Console.Out.Write("| " + int.Parse(currentCell.LiveNeighbors.ToString()) + " ");
                    }
                    else
                    {
                        Console.Out.Write("| ? ");
                    }
                    if (y == LiveBoard.BoardSize)
                    {
                        Console.Out.Write("|*");
                        Console.Out.WriteLine("");
                    }
                
                }
            }
        }

        public static void PlayGame()
        {
            bool gameIsPlaying = true;

            int row = 0;
            int column = 0;
            int cellsChecked = 0;
            int cellsCheckedCounter = LiveBoard.BoardSize * LiveBoard.BoardSize;

            for (int x = 1; x <= LiveBoard.BoardSize; x++)
            {
                for (int y = 1; y <= LiveBoard.BoardSize; y++)
                {
                    Cell livingCell = LiveBoard.GameBoard.Find(cell => cell.Column == x && cell.Row == y);
                    if(livingCell.Live)
                    {
                        cellsChecked++;
                    }
                }
            }

            while (gameIsPlaying)
            {
                Console.WriteLine("Please ender a Cell Row (Starting with 1): ");
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    row = (input - 1);
                }
                else
                {
                    Console.WriteLine("Please ender a Cell Row (Starting with 1): ");
                }

                Console.WriteLine("Please ender a Cell Column (Starting with 1): ");
                if (int.TryParse(Console.ReadLine(), out int input2))
                {
                    column = (input2 - 1);
                }
                else
                {
                    Console.WriteLine("Please ender a Cell Column (Starting with 1): ");
                }

                Cell selectedCell = LiveBoard.GameBoard.Find(cell => cell.Column == row && cell.Row == column);

                if (selectedCell.Live)
                {
                    selectedCell.Visited = true;
                    PrintBoard();
                    Console.WriteLine("Your hit a mine, Game Over!");
                    gameIsPlaying = false;
                }
                else
                {
                    selectedCell.Visited = true;
                    Console.Clear();
                    LiveBoard.floodFill(row, column);
                    PrintBoard();
                    cellsChecked++;
                }

                if (cellsChecked == cellsCheckedCounter)
                {
                        Console.WriteLine("Congratulations, your have Won!");
                        gameIsPlaying = false;
                }
            }
        }
    }
}
