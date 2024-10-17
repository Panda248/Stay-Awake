using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]
    int winTimer = 50000;
    [SerializeField]
    int sleepiness = 10000;
    [SerializeField]
    int sleepyRate = 1;
    [SerializeField]
    string loseScene = "", winScene = "";
    [SerializeField]
    float qtChance = 0.20f;
    float qtFreq = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
            Debug.Log(sleepiness);
        }

        if(winTimer-- <= 0)
        {
            SceneManager.LoadScene(winScene);
        }
    }
}
