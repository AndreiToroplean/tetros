using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetroActive : MonoBehaviour
{
    [SerializeField] Tetro tetro;
    [SerializeField] GameObject block;

    float lastTimeMoved = 0f;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Vector2Int pos in tetro.positions)
        {
            GameObject newBlock =  Instantiate(block, (Vector2)pos, Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
