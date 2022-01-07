using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    private PlayerMovement health;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement>().health -= 20;
        }
        //FindObjectOfType<SFXmanager>().PlayHurt();
    }
}
