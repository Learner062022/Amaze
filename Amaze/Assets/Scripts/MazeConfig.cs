using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    /// <summary>
    /// Stores maze generation settings and structural parameters.
    /// Acts as a persistent configuration manager across scenes.
    /// </summary>
    public class MazeConfig : MonoBehaviour
    {
        // Will incorporate following after achieving the simplest form of recursive backtracker: 
        // float loopDensity;
        // float randomizationFactor;
        // float branchingBias;
        // float deadEndPruningRate;
        // int seed;

        public Vector2Int MapSize = new(31, 31);

        public static MazeConfig Instance { get; private set; }

        int selectedDifficultyIndex = 0;

        /// <summary>
        /// Maps difficulty levels to maze generation algorithms. 
        /// Will incorporate other difficulties and algorithms 
        /// after achieving simplest recursive backtracker.
        /// </summary>
        readonly List<(string name, string algorithm)> mazeDifficulty = new()
        {
            ("Easy", "RecursiveBacktracker"),
            ("Medium", "Prims"),
            ("Hard", "Kruskal"),
            ("Expert", "HuntAndKill"),
            ("Insane", "RecursiveDivision")
        };
       
        public List<(string, string)> MazeDifficulty => mazeDifficulty;

        public int SelectedDifficultyIndex
        {
            set
            {
                if (selectedDifficultyIndex != value)
                    selectedDifficultyIndex = value;
            }

            get => selectedDifficultyIndex;
        }

        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}