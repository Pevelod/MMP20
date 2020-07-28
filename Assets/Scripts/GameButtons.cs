using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{

    
    public void Play_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayHard_Button()
    {
        SceneManager.LoadScene(6);
    }

    public void Weiter_Button()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    public void Impressum_Button()
        {
            Debug.Log("Impressum gedrueckt");
            SceneManager.LoadScene(11);
        }

    public void Quit_Button()
    {
        Debug.Log("QUIT gedrueckt");
        Application.Quit();
    }





}
