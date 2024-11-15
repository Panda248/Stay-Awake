using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuickTimeEvent : MonoBehaviour
{
    [SerializeField]
    int timer = 100;

    [SerializeField]
    int wakePower = 100;

    [SerializeField]
    public KeyCode key = KeyCode.Alpha2;

    [SerializeField]
    GamePlayLoop GamePlayLoop;

    private Animator animator;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();
    }
    //TODO ASSIGN IMAGE BASED OFF KEY
    

    private void Update()
    {
        if(Input.GetKeyDown(key))
        {
            Debug.Log("HELLOOO???");
            GamePlayLoop.ReduceSleepiness(wakePower);
            animator.Play("QuickTimeExit");
            Destroy(gameObject, 0.5f);//Magic number :(
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("QuickTimeExit") && timer-- <= 0)
        {
            animator.SetBool("Expire", true);
            Destroy(gameObject, 0.5f);
        }
    }
}
