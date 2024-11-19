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

    [SerializeField]
    List<KeyCode> possibleKeys = new();

    [SerializeField]
    List<Sprite> keySprites = new();

    private Animator animator;
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        animator = GetComponent<Animator>();

        transform.position = new Vector3(Random.Range(0,Screen.width), Random.Range(0,Screen.height), 0);

        int index = Random.Range(0, keySprites.Count);
        image.sprite = keySprites[index];
        key = possibleKeys[index];
    }
    //TODO ASSIGN IMAGE BASED OFF KEY
    

    private void Update()
    {
        if(Input.GetKeyDown(key))
        {
            Debug.Log("HELLOOO???");
            GamePlayLoop.ReduceSleepiness(wakePower);
            animator.SetBool("Exit", true);
            Destroy(gameObject, 1);//Magic number :(
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("QuickTimeExit") && timer-- <= 0)
        {
            Destroy(gameObject);
        }
    }
}
