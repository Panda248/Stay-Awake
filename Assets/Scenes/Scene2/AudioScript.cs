using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField]
    GamePlayLoop GamePlayLoop;

    AudioSource audioComp;
    // Start is called before the first frame update
    void Start()
    {
        audioComp = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        audioComp.pitch = 1 - GamePlayLoop.GetSleepyValue();
    }
}
