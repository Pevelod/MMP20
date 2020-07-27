using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class VirusScript : MonoBehaviour
{
    public GameObject deathEffect;

    bool isCoroutineExecuting = false;
    public float health = 4f;

    //UI Infos
    public bool istAmLeben = true;
    public string virus_StatusTXT = "Virus lebt!";

    public String getVirusStatusTXT()
    {
        return virus_StatusTXT;
    }
    public void update()
    {
        Debug.Log(istAmLeben);
    }
     IEnumerator ExecuteAfterTime(float time, Action task)
    {
        if (isCoroutineExecuting)
            yield break;

            isCoroutineExecuting = true;

            yield return new WaitForSeconds(time);

            task();

            isCoroutineExecuting = false;
    }

    void OnCollisionEnter2D (Collision2D colInfo)
    {

        if (colInfo.relativeVelocity.magnitude > health)
        {
            
            virus_StatusTXT = "Virus ist tot!";
            Die();
            


        }
     }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        
        StartCoroutine(ExecuteAfterTime(1f, () =>
            {            
                
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


            }));
        
        

            

    }
}


// laeuft 49:13