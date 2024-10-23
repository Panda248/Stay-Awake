using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    GamePlayLoop GamePlayLoop;
    float amplitude = 0.01f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        timer+= Time.unscaledDeltaTime;
        Quaternion deltaRotate = Quaternion.Euler(Mathf.Exp(GamePlayLoop.GetSleepyValue())*amplitude*Mathf.Cos(timer), 0, 0);

        transform.Rotate(deltaRotate.eulerAngles);
    }
}
