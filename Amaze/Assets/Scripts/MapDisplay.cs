using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Base class for mini map functionality.
    /// Displays the player's real-time position on the minimap UI.
    /// Designed to be extended by layout-specific implementations (e.g., TopLeftMiniMap, BottomRightMiniMap).
    /// </summary>
    public class MapDisplay : MonoBehaviour
    {
        [SerializeField] 
        RectTransform miniMapRectTransform;
    }
}