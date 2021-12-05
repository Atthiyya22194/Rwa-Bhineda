using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour 
{
    [SerializeField] private GameObject _tile1, _tile2;
    [SerializeField] private SpriteRenderer _renderer;

    public void Init(bool isOffsite)
    {
        //_renderer.gameObject = isOffsite ? _tile1 : _tile2;
    }
}
