using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tetro", menuName = "Tetro")]
public class Tetro : ScriptableObject
{
    [SerializeField] public List<Vector2Int> positions = new List<Vector2Int>(4);
    [SerializeField] Vector2Int anchor;
    [SerializeField] bool isAnchorCentered = false;
    [SerializeField] Color color = new Color { r=0f, g=0f, b=0f, a=1f };
}
