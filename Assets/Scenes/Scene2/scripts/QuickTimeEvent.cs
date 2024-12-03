using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickTimeEvent : MonoBehaviour
{
    [SerializeField]
    protected int timer = 100;

    [SerializeField]
    protected int wakePower = 100;

    [SerializeField]
    protected GamePlayLoop GamePlayLoop;

    [SerializeField]
    AudioClip win, lose;

    protected AudioSource audioSource;
    protected Animator animator;
    protected Boolean active;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playWin()
    {
        audioSource.clip = win;
        audioSource.Play();
        animator.SetTrigger("exit");
        active = false;
    }

    public void playLose()
    {
        audioSource.clip = lose;
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
        animator.SetTrigger("expire");
        active = false;
    }

    public void onCompletion()
    {
        GamePlayLoop.ReduceSleepiness(wakePower);
        
        Destroy(gameObject);
    }

    public void onExpire()
    {
        
        Destroy(gameObject);
    }
}
