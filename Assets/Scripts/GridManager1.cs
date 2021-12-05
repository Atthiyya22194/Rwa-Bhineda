using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager1 : MonoBehaviour
{
    [SerializeField]
    private int rows = 5;
    [SerializeField]
    private int cols = 8;
    [SerializeField]
    private float tileSize = 1;
    //[SerializeField] public GameObject tile1, tile2;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        GameObject referenceTile = (GameObject)Instantiate(Resources.Load("tile_black"));
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                /*if((row + col) % 2 == 0)
                {
                    Instantiate(tile1, new Vector3(row, 0, col), Quaternion.identity);
                }
                else
                {
                    if((row + col) % 2 == 1)
                    {
                        Instantiate(tile2, new Vector3(row, 0, col), Quaternion.identity);
                    }
                }*/
                GameObject tile = (GameObject)Instantiate(referenceTile, transform);
                float posX = col * tileSize;
                float posY = row * -tileSize;

                tile.transform.position = new Vector2(posX, posY);
            }
        }
        Destroy(referenceTile);
        float gridWidth = cols * tileSize;
        float gridHeigh = rows * tileSize;
        transform.position = new Vector2(-gridWidth / 2 + tileSize / 2, gridHeigh / 2 - tileSize / 2);
    }
}