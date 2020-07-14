using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusScript : MonoBehaviour
{
    public GameObject deathEffect;

    public float health = 4f;

    void OnCollisionEnter2D (Collision2D colInfo)
    {

        if (colInfo.relativeVelocity.magnitude > health)
        {
            Die();
        }
     }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}


// laeuft 49:13