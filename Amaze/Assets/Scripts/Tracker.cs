using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Tracks the positions of entities within the maze.
    /// </summary>
    public class Tracker : MonoBehaviour
    {
        [SerializeField]
        GameObject player;

        [SerializeField]
        GameObject collectable;

        Vector3 playerPos;
        Vector3 collectablePos;

        void Start()
        {
            playerPos = player.transform.position;
            collectablePos = collectable.transform.position;
        }

        void Update()
        {
            if (player.transform.position != playerPos)
            {
                playerPos = player.transform.position;
                if (playerPos == collectablePos)
                {
                    Destroy(collectable);
                    // add collectable to HUD
                }
            }
        }
    }
}