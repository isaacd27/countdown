using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameTimeManager : MonoBehaviour
{
    bool timerend = false;
    public float timer = 300000;
    public float timerDecreaseRate = 1;
    public TMP_Text TimerText;
    // Start is called before the first frame 
    
    public float gettimertime()
    {
        
        return timer;
    }

    public bool gettimerended()
    {
        return timerend;
    }

    public void addTimerTime(float t)
    {
        timer += t;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= timerDecreaseRate*Time.deltaTime;

        if(timerDecreaseRate <= 0)
        {
            timerDecreaseRate = 0;
            TimerText.text = "DEBUG MODE";
        }
        else
        {
            TimerText.text = timer.ToString();
        }

        if (timer <= 0)
        {
            timerend = true;
        }else{
            timerend = false;
        }
    }
}
