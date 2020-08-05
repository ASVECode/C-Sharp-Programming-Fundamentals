using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.CompilerServices;

namespace _07.Labyrinth
{
    class Labyrinth
    {
        static char[,] lab = {

            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},

        };

        static char[] path =
            new char[lab.GetLength(0) * lab.GetLength(1)];
        static int position = 0;

        static void FindPath(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                //out of the labyrinth
                return;
            }
            //append the direction to the path
            path[position] = direction;
            position++;

            //check if the exit is found
            if (lab[row, col] == 'e')
            {
                PrintPath(path, 1, position - 1);
            }

            if (lab[row, col] == ' ')
            {
                lab[row, col] = 's';
                //Invoke recurison to explore all possible directions

                FindPath(row, col - 1, 'L');//left
                FindPath(row - 1, col, 'U');//up
                FindPath(row, col + 1, 'R');//right
                FindPath(row + 1, col, 'D');//down

                //Mark back the current ceil as free
                lab[row, col] = ' ';
            }

            //Remove the direction from the path
            position--;
        }
        static void PrintPath(
            char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");
            for (int pos = startPos; pos <= endPos; pos++)
            {
                Console.Write(path[pos]);
            }
            Console.WriteLine();
        }
        static void Main()
        {
            FindPath(0, 0, 'S');
        }
    }
}
