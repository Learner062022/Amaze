using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Represents a cell in a maze, including its wall flags and visited state.
    /// </summary>
    public class MazeCell
    {
        public bool HasNorthWall { get; set; } = true;
        public bool HasEastWall { get; set; } = true;
        public bool HasSouthWall { get; set; } = true;
        public bool HasWestWall { get; set; } = true;
        public bool IsVisited { get; set; } = false;
    }
}