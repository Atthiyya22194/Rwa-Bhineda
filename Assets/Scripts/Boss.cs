using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "Boss")
        {
            HealthBar.health -= 20;
            //Destroy(gameObject);
        }
        FindObjectOfType<SoundManager>().Fire();
    }
}
