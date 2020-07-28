using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manipulate : MonoBehaviour
{
    public void ReloadSCN()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

            
    }

    public void SkipSCN()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void BackSCN()
    {
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
            
    }

    public void EndSCN()
    {
        {
            SceneManager.LoadScene(0);
        }     
    }

    public void Quit_Button()
    {
        Debug.Log("QUIT gedrueckt");
        Application.Quit();
    }
    
}
