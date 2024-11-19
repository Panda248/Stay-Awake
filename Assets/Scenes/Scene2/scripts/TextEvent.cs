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

    [SerializeField]
    List<string> texts = new List<string>()
    {
        "Llorem Ipsum",
        "Yes Sir",
        "1+1=2",
        "Okay",
        "Pol Pot"
    };

    private TMP_InputField inputField;
    private TextMeshProUGUI textMesh;
    private Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        inputField = transform.GetComponentInChildren<TMP_InputField>();
        textMesh = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();

        transform.position = new Vector3(Random.Range(0, Screen.width), Random.Range(0, Screen.height), 0);

        textMesh.text = texts[Random.Range(0, texts.Count)];
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
