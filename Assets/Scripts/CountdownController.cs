using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public float totalTime;
    public Text text;
    private float seconds;


    public void update()
    {
        totalTime -= Time.deltaTime;

        seconds = (int)(totalTime % 60);

        text.text = seconds.ToString();
    }
}
