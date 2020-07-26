using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PfeilStart : MonoBehaviour
{

    private bool isPressed = false;

    public GameObject NextScene;
    public void Update()
    {
        if (isPressed)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Single); //Ohne Funktion
        }
    }

    void OnMouseDown ()
    {
        isPressed = true;
    }

   void OnMouseUp()
    {
        isPressed = false;
    }
}
