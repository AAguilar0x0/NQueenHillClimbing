using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace NQueenHillClimbing
{
    class Board
    {
        public int n;
        public int lowestMove;
        public int[] columns;
        public int[,] heurestic;

        public Board(int nQueens)
        {
            n = nQueens;
            Random rand = new Random();
            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = rand.Next(n);
            }
            columns = temp;
            heurestic = new int[n, n];
        }

        public Board(int[] state)
        {
            columns = (int[])state.Clone();
            n = columns.Length;
            heurestic = new int[n, n];
        }

        public Board(Board state)
        {
            columns = (int[])state.columns.Clone();
            n = columns.Length;
            heurestic = new int[n, n];
        }

        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                columns[i] = rand.Next(n);
            }
        }

        public void copy(Board state)
        {
            columns = (int[])state.columns.Clone();
            n = columns.Length;
            heurestic = new int[n, n];
        }

        public int getAttackingPairs()
        {
            int found = 0;
            for (int column = 0; column < n; column++)
            {
                for (int row = column + 1; row < n; row++)
                {
                    found +=
                        Convert.ToInt32(columns[column] == columns[row]) +
                        Convert.ToInt32(row <= column + columns[column] && (columns[column] + column - row) == columns[row]) +
                        Convert.ToInt32((columns[column] + row - column) == columns[row]);
                }
            }

            return found;
        }

        public int[,] getHeurestic()
        {
            lowestMove = n * n;
            for (int column = 0; column < n; column++)
            {
                Board temp = new Board(this);
                for (int row = 0; row < n; row++)
                {
                    temp.columns[column] = row;
                    heurestic[row, column] = row != columns[column] ? temp.getAttackingPairs() : n * n;
                    lowestMove = heurestic[row, column] <= lowestMove ? heurestic[row, column] : lowestMove;
                }
            }

            return heurestic;
        }

        public List<Point> getLowestMoves()
        {
            List<Point> lowestMoves = new List<Point>();
            for (int column = 0; column < n; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (heurestic[row, column] == lowestMove)
                    {
                        lowestMoves.Add(new Point(column, row));
                    }
                }
            }

            return lowestMoves;
        }
    }
}
