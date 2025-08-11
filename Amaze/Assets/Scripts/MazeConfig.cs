using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Stores maze generation settings and structural parameters.
    /// Acts as a persistent configuration manager across scenes.
    /// </summary>
    public class MazeConfig : MonoBehaviour
    {
        public static MazeConfig Instance { get; private set; }

        public string SelectedAlgorithm => mazeDifficulty[selectedDifficultyIndex].algorithm;

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

        [SerializeField]
        float mazeHeight;

        public float MazeHeight => mazeHeight;

        int selectedDifficultyIndex = 0;

        readonly List<(string name, string algorithm)> mazeDifficulty = new()
        {
            ("Easy", "RecursiveBacktracker"),
            ("Medium", "Prims"),
            ("Hard", "Kruskal"),
            ("Expert", "HuntAndKill"),
            ("Insane", "RecursiveDivision")
        };

        public int SelectedDifficultyIndex
        {
            get => selectedDifficultyIndex;
            set
            {
                if (selectedDifficultyIndex != value)
                {
                    selectedDifficultyIndex = value;
                }
            }
        }
    }
}