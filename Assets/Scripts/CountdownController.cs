using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountdownController : MonoBehaviour
{
    

    int countDownStartValue = 9;
    public Text timerUI;
    public void start()
    {
        countTimer();
    }

    public void countTimer()
        {
            if (countDownStartValue > 0)
            {
                TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
                Debug.Log("Timer: " + countDownStartValue + " : " + spanTime.Seconds);
                timerUI.text = spanTime.Seconds.ToString();
                countDownStartValue--;
                Invoke("countDownTimer", 1.0f);
                
            }
            else
            {
                Debug.Log("Countdown Ende");
            }
        }

}
