using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    GamePlayLoop GamePlayLoop;
    [SerializeField, Range(0f,0.01f)]
    float xAmplitude = 0.01f;
    [SerializeField, Range(0f, 1f)]
    float xAmplitudeGrowthRate = 0.5f;
    [SerializeField, Range(0f, 0.001f)]
    float yAmplitude = 0.001f;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        timer+= Time.unscaledDeltaTime;
        float deltaX = Mathf.Exp(GamePlayLoop.GetSleepyValue() * xAmplitudeGrowthRate) * xAmplitude * Mathf.Cos(timer);
        Quaternion deltaRotate = Quaternion.Euler(deltaX, yAmplitude * Mathf.Sin(timer/5), 0);

        transform.Rotate(deltaRotate.eulerAngles);
    }
}
