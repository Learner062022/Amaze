using Assets.Scripts;
using UnityEngine;

/// <summary>
/// Generates the maze grid and triggers rendering based on configuration.
/// </summary>
public class MazeGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject floor;

    [SerializeField]
    MazeConfig mazeConfig;

    MazeCell[,] mazeGrid;

    Vector3 posFloor;
    Vector3 scaleFloor;
    Vector3 mazeOrigin;

    public MazeCell[,] MazeGrid
    {
        get => mazeGrid;
        set => mazeGrid = value;
    }

    void Awake()
    {
        posFloor = floor.transform.position;
        scaleFloor = transform.localScale;
    }

    void Start()
    {
        // TODO: Calculate maze grid dimensions using floor scale and MazeConfig settings (e.g., cell size or maze height)

        mazeOrigin = new(
            (posFloor.x * scaleFloor.x) - 0.5f,
            0,
            (posFloor.z * scaleFloor.z) - 0.5f
        );

        // TODO: Store mazeOrigin or pass it to MazeRenderer for correct cell placement
    }

    void Update()
    {
        // TODO: Add runtime logic if needed (e.g., debug input or regeneration triggers)
    }

    public void GenerateMaze()
    {
        // TODO: Retrieve selected maze algorithm name from MazeConfig
        // TODO: Initialize mazeGrid with MazeCell instances based on calculated dimensions
        // TODO: Use selected algorithm to carve paths and update wall flags in mazeGrid
        // TODO: Ensure walls are removed between connected cells based on path carving
        // TODO: Send mazeGrid and mazeOrigin to MazeRenderer for visual instantiation
    }
}