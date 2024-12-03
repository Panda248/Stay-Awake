using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class MouseOverEvent : QuickTimeEvent
{

    private float alphaThreshold = 0.1f;

    // Start is called before the first frame update
    void Awake()
    {

        transform.position = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer-- <= 0 && active)
        {
            playLose();
        }
    }

 

    
}
