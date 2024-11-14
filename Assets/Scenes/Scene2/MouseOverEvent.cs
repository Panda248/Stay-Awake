using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class MouseOverEvent : MonoBehaviour
{
    [SerializeField]
    int timer = 100;

    [SerializeField]
    int wakePower = 100;

    [SerializeField]
    GamePlayLoop GamePlayLoop;

    private float alphaThreshold = 0.1f;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(timer-- <= 0)
        {
            animator.SetTrigger("expire");
        }
    }

    void onCompletion()
    {
        GamePlayLoop.ReduceSleepiness(wakePower);
        onExpire();
    }

    void onExpire()
    {
        Destroy(gameObject);
    }

    
}
