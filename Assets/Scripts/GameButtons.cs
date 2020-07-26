﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    public void Play_Button()
    {
        SceneManager.LoadScene(1);
    }

    public void Weiter_Button()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    public void Quit_Button()
    {
        Debug.Log("QUIT gedrueckt");
        Application.Quit();
    }





}
