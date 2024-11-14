using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float currentTime = 0f;
    private float startTime = 7 * 3600 + 59 * 60 + 30;
    private float endTime = 8 * 3600;

    void Start()
    {
        currentTime = startTime;
        UpdateTimerText(currentTime);
    }

    void Update()
    {
        if (currentTime < endTime)
        {
            currentTime += Time.deltaTime;
            UpdateTimerText(currentTime);
        }
        else
        {
            currentTime = endTime;
            UpdateTimerText(currentTime);
        }
    }

    void UpdateTimerText(float timeInSeconds)
    {
        int hours = (int)(timeInSeconds / 3600) % 24;
        int minutes = (int)(timeInSeconds / 60) % 60;
        int seconds = (int)timeInSeconds % 60;

        timerText.text = string.Format("{0:00}:{1:00}:{2:00} AM", hours, minutes, seconds);
    }
}