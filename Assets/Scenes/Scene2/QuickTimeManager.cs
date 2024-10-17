using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeManager : MonoBehaviour
{
    [SerializeField]
    float qtChance = 0.20f;
    [SerializeField]
    float qtPeriod = 100f;
    [SerializeField]
    GameObject QuickTimeEvent;

    private int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(timer++ >= qtPeriod)
        {
            if(Random.Range(0,1) < qtChance)
            {

            }
        }
    }
}
