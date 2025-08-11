using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class MazeManager : MonoBehaviour
{
    [SerializeField]
    Dropdown difficultyDropdown;

    [SerializeField]
    MazeGenerator generator;

    [SerializeField]
    MazeConfig configurator;

    // TODO (Inspector): Assign difficultyDropdown and generator in inspector
    // TODO (Config): Assign MazeConfig.Instance to configurator for centralized settings

    void Awake()
    {
        // TODO (Config): Assign MazeConfig.Instance to configurator for centralized settings
    }

    void Start()
    {
        // TODO (UI Setup): Populate dropdown options using config.GetMazeDifficulties() or similar accessor
        // TODO (UI Setup): Set dropdown value to config.SelectedDifficultyIndex
        // TODO (UI Setup): Refresh dropdown UI to reflect current selection
        // TODO (UI Setup): Add listener to difficultyDropdown to handle selection changes
        // TODO (Maze Init): Call generator.GenerateMaze() when difficulty is changed or on initial load
    }

    void OnDifficultyChanged(int index)
    {
        // TODO (Config Update): Update config.SelectedDifficultyIndex with new value
        // TODO (Maze Update): Regenerate maze using updated configuration
        // TODO (Rendering): Needs to trigger MazeRenderer to render maze after generation
    }
}