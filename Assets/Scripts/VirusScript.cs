using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        // Destroy(gameObject.GetComponent(Ball);
        if (SceneManager.GetActiveScene().buildIndex < 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene(0, LoadSceneMode.Single);
            }
        
    }
}


// laeuft 49:13