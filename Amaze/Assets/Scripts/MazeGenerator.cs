using Assets.Scripts;
using PlasticPipe.PlasticProtocol.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Generates the maze using parameters from MazeConfig.
/// Responsible for applying the selected algorithm and building the maze structure.
/// </summary>
public class MazeGenerator : MonoBehaviour
{
    MazeConfig mazeConfig;
    Vector3 mazeOrigin;
    GameObject mazeRoot;

    public MazeGenerator(MazeConfig mazeConfig)
    {
        // now can access the 2D array tracking the visited/unvisited cells
        this.mazeConfig = mazeConfig; 

        // Maze is built on top of an existing plane in the scene
        // Plane acts as the floor; no need to instantiate floor prefabs
        Transform transform = mazeConfig.Floor.transform;
        Vector3 posFloor = transform.position;
        Vector3 scaleFloor = transform.localScale;

        // Maze origin is calculated from plane position and scaled dimensions
        // Maze is centered on the plane using offset based on width and height
        mazeOrigin = new Vector3(
            (posFloor.x * scaleFloor.x) - 0.5f,
            0,
            (posFloor.z * scaleFloor.z) - 0.5f
            );
    }

    
    // Notes:
    
    
    
    // - Each cell's position is offset from origin using cell size
    // - Walls are instantiated as children of a single parent GameObject ("MazeRoot")
    // - Adjacent cells must share wall reference to allow proper removal
    // - Wall prefabs are positioned with vertical offset to sit above the plane
    // - Directional logic is used to navigate grid and remove walls between cells
    // - Final maze structure is a single GameObject containing all remaining walls

    void Start() {
        
    }

    void Update() {

    }
}