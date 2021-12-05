using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] GameObject _tilePrefabsWhite = null;
    [SerializeField] GameObject _tilePrefabsBlack = null;
    [SerializeField] int _column = 7;
    [SerializeField] int _rows = 7;
    [SerializeField] float _drawDelay = 0.1f;
    Vector3 _startPosition;

    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;

        StartCoroutine(GenerateGrid());
    }

    private IEnumerator GenerateGrid()
    {
        bool isBlack = true;
        for (int column = 0; column < _column; column++)
        {
            for (int row = 0; row < _rows; row++)
            {
                if (isBlack)
                {
                    Instantiate(
                        _tilePrefabsBlack,
                        new Vector3(row, 0, column) + transform.position,
                        Quaternion.Euler(90f, 0f, 0f),
                        transform);
                }
                else
                {
                    Instantiate(
                        _tilePrefabsWhite,
                        new Vector3(row, 0, column) + transform.position,
                        Quaternion.Euler(90f, 0f, 0f),
                        transform);
                }
                isBlack = !isBlack;
                yield return new WaitForSeconds(_drawDelay);
            }
            if (_rows % 2 == 0)
            {
                isBlack = !isBlack;
            }
        }
    }
}
