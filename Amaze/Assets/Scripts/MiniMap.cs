using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Base class for minimap functionality.
    /// Handles positioning and tracking of player location within the minimap UI.
    /// Intended to be extended by specific minimap layout implementations (e.g., TopLeftMiniMap, BottomRightMiniMap)
    /// </summary>
    public class MiniMap : MonoBehaviour
    {
        [SerializeField] 
        RectTransform miniMapRectTransform;

        [SerializeField]
        Transform playersLocation;
    }
}
