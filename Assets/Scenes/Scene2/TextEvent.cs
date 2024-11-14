using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextEvent : MonoBehaviour
{
    [SerializeField]
    int timer = 500;

    [SerializeField]
    int wakePower = 100;

    [SerializeField]
    GamePlayLoop GamePlayLoop;

    private TMP_InputField inputField;
    private TextMeshProUGUI textMesh;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        inputField = transform.GetComponentInChildren<TMP_InputField>();
        textMesh = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (inputField.text.Equals(textMesh.text))
        {
            animator.SetTrigger("exit");
        }
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
