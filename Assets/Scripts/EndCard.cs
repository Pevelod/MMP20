using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndCard : MonoBehaviour
{

    //bool isCoroutineExecuting = false;

    int countDownStartValue = 9;
    public Text timerUI;
    // Start is called before the first frame update

    void countDownTimer()
        {
            if (countDownStartValue > 0)
            {
                TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
                //Debug.Log("1Timer: " + countDownStartValue + " 1: " + spanTime.Seconds);
                timerUI.text = spanTime.Seconds.ToString();
                //Debug.Log("2Timer: " + countDownStartValue + " 2: " + spanTime.Seconds);
                countDownStartValue--;
                //Debug.Log("3Timer: " + countDownStartValue + " 3: " + spanTime.Seconds);
                Invoke("countDownTimer", 1.0f);
                //Debug.Log("4Timer: " + countDownStartValue + " 4: " + spanTime.Seconds);
            }
            else
            {
                Debug.Log("Countdown Ende");
                SceneManager.LoadScene(0);
            }
        }
    void Start()
    {
            countDownTimer();
    }


    void Update()
    {
        //countDownTimer();
    }


    
    

    
}
