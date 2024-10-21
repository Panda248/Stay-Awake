using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayLoop : MonoBehaviour
{
    [SerializeField]
    public int winTimer = 50000;
    [SerializeField]
    public int sleepiness = 10000;
    [SerializeField]
    public int sleepyRate = 1;
    [SerializeField]
    string loseScene = "", winScene = "";
    

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
        }

        if(winTimer-- <= 0)
        {
            SceneManager.LoadScene(winScene);
        }
    }
}
