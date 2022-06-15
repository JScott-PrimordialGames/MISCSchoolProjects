using System;
using System.Collections.Generic;
using System.Text;

namespace MilestoneProject
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Visited { get; set; }
        public bool Live { get; set; }
        public int LiveNeighbors { get; set; }

        public Cell(int column, int row, bool visited, bool live, int liveNeighbors)
        {
            Column = column;
            Row = row;
            Visited = visited;
            Live = live;
            LiveNeighbors = liveNeighbors;

        }

        public Cell()
        {
            Row = -1;
            Column = -1;
            Visited = false;
            Live = false;
            LiveNeighbors = 0;
        }
    }

}
