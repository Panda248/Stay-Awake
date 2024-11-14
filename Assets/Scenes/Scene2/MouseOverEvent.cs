using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class MouseOverEvent : MonoBehaviour
{
    float alphaThreshold = 0.1f;

    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().alphaHitTestMinimumThreshold = alphaThreshold;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(animator.GetCurrentAnimatorStateInfo(0).IsName("Exit"))
        {
            Destroy(gameObject, 0.1f);
        }
    }

    
}
