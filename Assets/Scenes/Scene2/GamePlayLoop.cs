using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayLoop : MonoBehaviour
{
    [SerializeField]
    public int winTimer = 50000;
    [SerializeField]
    public int maxSleepiness = 10000;
    [SerializeField]
    public int sleepyRate = 1;
    [SerializeField]
    string loseScene = "", winScene = "";

    [SerializeField]
    private int sleepiness;

    private void Awake()
    {
        sleepiness = maxSleepiness;

    }
    void FixedUpdate()
    {

        if (sleepiness <= 0)
        {
            SceneManager.LoadScene(loseScene);
        }
        else
        {
            sleepiness -= sleepyRate;
        }

        if(winTimer-- <= 0)
        {
            SceneManager.LoadScene(winScene);
        }
    }
    
    public void ReduceSleepiness(int amount)
    {
        sleepiness += amount;
    }
    public float GetSleepyValue()
    {
        return 1 - ((float)sleepiness / ((float)maxSleepiness));
    }
}
