using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private HealthBar health;

    void OnTriggerEnter2D(Collider2D coll)
    {
       health.currentHealth -= 20;
       Destroy(gameObject);
    }
}
