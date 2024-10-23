using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    GamePlayLoop GamePlayLoop;
    float amplitude = 5;
    int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void FixedUpdate()
    {
        timer++;
        Quaternion deltaRotate = Quaternion.Euler(GamePlayLoop.GetSleepyValue()*amplitude*Mathf.Sin(timer/10), transform.rotation.y, transform.rotation.z);
        Debug.Log(deltaRotate.x);
        transform.rotation = deltaRotate;
    }
}
