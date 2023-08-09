using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    [SerializeField] private GameObject _blockPrefab;

    [SerializeField] private int _col, _row;

    [SerializeField] private Vector2 _startPosition;

    // Start is called before the first frame update
    void Start()
    {
        var blockSize = _blockPrefab.GetComponent<SpriteRenderer>().bounds.size;

        var xStart = - (_col * blockSize.x) / 2;

        float yEnd = _startPosition.y - ( _row * blockSize.y);
        float xEnd = xStart + ( _col * blockSize.x );

        Debug.Log(yEnd);

        for (float y = _startPosition.y; y > yEnd; y -= blockSize.y)
        {
            for (float x = xStart; x < xEnd; x += blockSize.x)
            {
                Instantiate(_blockPrefab, new Vector3(x + (blockSize.x / 2f), y + (blockSize.y / 2f), 0), Quaternion.identity);
            }
        }
    }

}
