using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    /// <summary>
    /// Represents a cell in a maze, including its type and visited state.
    /// </summary>
    public class MazeCell
    {
        enum CellType { 
            Wall,
            Path,
            Start,
            End
        }

        bool isVisited; 
    }
}