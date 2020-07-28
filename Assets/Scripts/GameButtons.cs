using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{

    int scenes = 3;
    public void Play_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayHard_Button()
    {
        SceneManager.LoadScene(4);
    }

    public void Weiter_Button()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    public void Impressum_Button()
        {
            Debug.Log("Impressum gedrueckt");
            SceneManager.LoadScene(7);
        }

    public void Quit_Button()
    {
        Debug.Log("QUIT gedrueckt");
        Application.Quit();
    }





}
